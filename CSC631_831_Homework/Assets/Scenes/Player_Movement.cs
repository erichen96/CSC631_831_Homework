using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 700f;
    public float backwardForce = 500f;
    public float sidewaysForce = 500f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("w")){
            rb.AddForce(0,0, forwardForce * Time.deltaTime);
        }

        if(Input.GetKey("s")){
            rb.AddForce(0,0, -backwardForce * Time.deltaTime);
        }

        if(Input.GetKey("a")){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0,0);
        }
        
        if(Input.GetKey("d")){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0,0);
        }
        
    }
}
