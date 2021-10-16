using UnityEngine;

public class AirSpecialBounce : MonoBehaviour, IAirSpecial
{

    [Range(0, 1)]
    public float SlowDownFactor = 1;
    

    /*void FixedUpdate()
    {
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();
        Debug.Log(rb.velocity.y);
    }*/

    public void ExecuteAirSpecial()
    {
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();

        Debug.Log("this is the initial speed " + rb.velocity.magnitude);

        //if (rb.velocity.y < 0) 
        //{
            rb.velocity = (new Vector2(rb.velocity.x, -rb.velocity.y)) * (1 - SlowDownFactor);
            Debug.Log("this is the new speed " + rb.velocity.magnitude);
            
        //}

        
        
        //throw new System.NotImplementedException();
    }
}
