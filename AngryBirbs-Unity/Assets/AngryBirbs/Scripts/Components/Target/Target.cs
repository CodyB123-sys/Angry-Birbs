using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [Range( 0, 20 )]
    public float MinimumBreakSpeed = 10;

    private void OnCollisionEnter2D( Collision2D collision )
    {
        //Debug.Log(collision.rigidbody.name);
        Debug.Log(collision.gameObject.GetComponent<Rigidbody2D>().velocity);

        if (Mathf.Abs(collision.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude) >= MinimumBreakSpeed)
        {
            DestroyTarget();
            
        }
        //throw new System.NotImplementedException();
    }

    public void DestroyTarget()
    {
        Destroy( gameObject );
    }
}
