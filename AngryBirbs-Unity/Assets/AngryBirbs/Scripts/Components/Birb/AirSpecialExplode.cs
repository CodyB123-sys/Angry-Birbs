using UnityEngine;

public class AirSpecialExplode : MonoBehaviour, IAirSpecial
{
    [Range(0, 5)]
    public float BlastRadius = 2;
    int targetMasks = new LayerMask();
    Collider2D[] targets;
    GameObject target;

    

    public void ExecuteAirSpecial()
    {
        targets = Physics2D.OverlapCircleAll(this.transform.position, BlastRadius, LayerMask.GetMask("Target"));

        foreach (Collider2D colliders in targets)
        {
            colliders.GetComponent<Target>().DestroyTarget();
            //Debug.Log("activating special move");
        }

        //throw new System.NotImplementedException();
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, BlastRadius);
    }
}
