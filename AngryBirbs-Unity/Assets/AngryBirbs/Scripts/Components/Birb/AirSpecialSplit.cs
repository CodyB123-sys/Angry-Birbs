using UnityEngine;

public class AirSpecialSplit : MonoBehaviour, IAirSpecial
{
    public float SplitAngleInDegrees = 10;
    GameObject blueBirb1;
    GameObject blueBirb2;
    GameObject blueBirb3;

    public void ExecuteAirSpecial()
    {
        blueBirb1 = this.gameObject;
        blueBirb2 = Instantiate(this.gameObject, this.transform.position, Quaternion.identity);
        blueBirb3 = Instantiate(this.gameObject, this.transform.position, Quaternion.identity);

        blueBirb2.GetComponent<Rigidbody2D>().velocity = new Vector2(blueBirb1.GetComponent<Rigidbody2D>().velocity.x, blueBirb1.GetComponent<Rigidbody2D>().velocity.y + SplitAngleInDegrees);
        //throw new System.NotImplementedException();
    }
}
