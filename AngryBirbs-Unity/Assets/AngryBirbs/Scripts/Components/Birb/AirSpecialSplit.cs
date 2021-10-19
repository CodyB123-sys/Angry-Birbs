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

        // find speed of initial
        float birdSpeed = blueBirbrb1.velocity.magnitude;

        //// find direction -> angle of initial
        float initialAngle = Mathf.Atan2(blueBirbrb1.velocity.y, blueBirbrb1.velocity.x);
        float angle2;
        float angle3;

        // calculate angle above and below
        angle2 = initialAngle + (SplitAngleInDegrees * Mathf.Deg2Rad);
        angle3 = initialAngle - (SplitAngleInDegrees * Mathf.Deg2Rad);

        // set new directions
        Vector2 birdDirection2 = new Vector2 (Mathf.Cos(angle2), Mathf.Sin(angle2));
        Vector2 birdDirection3 = new Vector2 (Mathf.Cos(angle3), Mathf.Sin(angle3));


        blueBirbrb2.velocity = birdDirection2 * birdSpeed;  //someDirection * someSpeed;
        blueBirbrb3.velocity = birdDirection3 * birdSpeed;  //someDirection * someSpeed;






        //blueBirb2.GetComponent<Rigidbody2D>().velocity = new Vector2(blueBirb1.GetComponent<Rigidbody2D>().velocity.x, blueBirb1.GetComponent<Rigidbody2D>().velocity.y + SplitAngleInDegrees);
        //throw new System.NotImplementedException();
    }
}
