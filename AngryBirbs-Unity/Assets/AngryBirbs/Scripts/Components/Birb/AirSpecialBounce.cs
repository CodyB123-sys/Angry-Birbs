using UnityEngine;

public class AirSpecialBounce : MonoBehaviour, IAirSpecial
{
    [Range( 0, 1 )]
    public float SlowDownFactor = 1;
    

    public void ExecuteAirSpecial()
    {
         
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();
        
        

        rb.AddForce(Vector2.up * -rb.velocity.y*2, ForceMode2D.Impulse);

        throw new System.NotImplementedException();
    }
}
