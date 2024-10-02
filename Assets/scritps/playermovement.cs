using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb; // renomme rigidbody par rb
    public bool cubeIsOnTheGround = true;
    //public bool gel = false;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float backForce = 20f;
    public GameManager GM;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);//ajoute une force en avant

        if (Input.GetKey("d")) //ajoute une force à droite
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("q"))//ajoute une force à gauche
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetButtonDown("Jump") && cubeIsOnTheGround == true)
        {
            rb.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
            cubeIsOnTheGround = false;
        }

        if (rb.position.y <= -0.8f)
        {
            GM.EndGame();
        }
    }
   private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "RechargeSaut" || collision.gameObject.name == "RechargeSaut(1)" || collision.gameObject.name == "RechargeSaut(2)")
        {
            cubeIsOnTheGround = true;
        }
    }
  /** private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "RallentissementDebut")
        {
            gel = true;
        }
        if (gel = true)
        {
            if (Input.GetKey("k"))//ajoute une force permettant freiner
            {
                rb.AddForce(0, 0, -backForce * Time.deltaTime, ForceMode.VelocityChange);
            }
        }
    }**/
    // si retiré permet un seul saut, plus simple pour pouvoirs/bonus
}
