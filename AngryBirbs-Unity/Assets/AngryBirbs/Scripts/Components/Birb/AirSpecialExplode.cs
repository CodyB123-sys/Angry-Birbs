using UnityEngine;

public class AirSpecialExplode : MonoBehaviour, IAirSpecial
{
    [Range(0, 5)]
    public float BlastRadius = 2;
    int targetMasks = new LayerMask();
    Collider2D[] targets;
    Target target;

    public void ExecuteAirSpecial()
    {
        //targetMask = LayerMask.GetMask("Target");
        targets = Physics2D.OverlapCircleAll(this.transform.position, BlastRadius, LayerMask.GetMask("Target"));

        foreach (Collider2D colliders in targets)
        {
            colliders.GetComponent<Target>().DestroyTarget();
            Debug.Log("activating special move");
        }

        //Debug.Log("this special move is activating");
        //throw new System.NotImplementedException();
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }*/

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, BlastRadius);
    }
}
