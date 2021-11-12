using UnityEngine;

public class AirSpecialSplit : MonoBehaviour, IAirSpecial
{
    public float SplitAngleInDegrees = 10;

    GameObject blueBirb1;
    GameObject blueBirb2;
    GameObject blueBirb3;

    Rigidbody2D blueBirbrb1;
    Rigidbody2D blueBirbrb2;
    Rigidbody2D blueBirbrb3;

    //Birb birb;

    public void ExecuteAirSpecial()
    {
        blueBirb1 = this.gameObject;
        blueBirb2 = Birb.MakeBirbCopy(this.gameObject);
        blueBirb3 = Birb.MakeBirbCopy(this.gameObject);

        blueBirbrb1 = this.gameObject.GetComponent<Rigidbody2D>();
        blueBirbrb2 = blueBirb2.GetComponent<Rigidbody2D>();
        blueBirbrb3 = blueBirb3.GetComponent<Rigidbody2D>();

        blueBirbrb2.simulated = true;
        blueBirbrb3.simulated = true;

        float birdSpeed = blueBirbrb1.velocity.magnitude;

        float initialAngle = Mathf.Atan2(blueBirbrb1.velocity.y, blueBirbrb1.velocity.x);
        float angle2;
        float angle3;

        angle2 = initialAngle + (SplitAngleInDegrees * Mathf.Deg2Rad);
        angle3 = initialAngle - (SplitAngleInDegrees * Mathf.Deg2Rad);

        Vector2 birdDirection2 = new Vector2 (Mathf.Cos(angle2), Mathf.Sin(angle2));
        Vector2 birdDirection3 = new Vector2 (Mathf.Cos(angle3), Mathf.Sin(angle3));


        blueBirbrb2.velocity = birdDirection2 * birdSpeed;  
        blueBirbrb3.velocity = birdDirection3 * birdSpeed;

        //Debug.Log("this is blueBird 2 direction " + birdDirection2);
        //Debug.Log("this is bluebird 3 direction: " + birdDirection3);

        //throw new System.NotImplementedException();
    }
}
