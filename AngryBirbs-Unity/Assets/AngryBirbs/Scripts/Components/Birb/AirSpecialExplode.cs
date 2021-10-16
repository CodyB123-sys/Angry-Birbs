using UnityEngine;

public class AirSpecialExplode : MonoBehaviour, IAirSpecial
{
    [Range( 0, 5 )]
    public float BlastRadius = 2;
    public LayerMask layerMask;
    public bool targetInPosition;
    Target target;

    public void ExecuteAirSpecial()
    {
        target = GetComponent<Target>();
        targetInPosition = Physics2D.OverlapCircle(this.transform.position, BlastRadius, layerMask);

        if (targetInPosition == true)
        {
            target.DestroyTarget();
        }
        //throw new System.NotImplementedException();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, BlastRadius);
    }
}
