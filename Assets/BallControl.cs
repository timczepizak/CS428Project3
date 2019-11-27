using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{

    private Rigidbody ballV;
    private Transform ballT;
    public FootController LeftFoot;
    public FootController RightFoot;
    public GameObject ball;
    public Transform spawn;
    private float counter;
    private bool startCounter;
    public float verticalAssistance;
    private AudioSource AS;



    // Start is called before the first frame update
    void Start()
    {
        
        ballV = this.GetComponent<Rigidbody>();
        ballT = this.transform;
        startCounter = false;
        AS = this.GetComponent<AudioSource>();


    }

    private void Update()
    {
        LeftFoot = (FootController)GameObject.FindGameObjectWithTag("LeftFoot").GetComponent("FootController");
        RightFoot = (FootController)GameObject.FindGameObjectWithTag("RightFoot").GetComponent("FootController");
        
        //if (counter < 3)
        //{
        //    counter = counter + Time.deltaTime;
        //}
        //if (counter > 3)
        //{
        //    Destroy(ball);
        //    ball.transform.position = spawn.position;
        //    ball = Instantiate(ball);
        //    startCounter = false;

        //    counter = 0;
        //}
    }



    void OnCollisionEnter(Collision collision)
    {

        
        
        ballV = ball.GetComponent<Rigidbody>();
        ballT = ball.transform;
        counter = 0;
        startCounter = true;


        if (collision.gameObject.tag.Equals("LeftFoot"))
        {
            AS.Play();
            if (LeftFoot.GetVelocity().magnitude > 8)
            {
                ballV.velocity = new Vector3(LeftFoot.GetVelocity().x * 1.5f, (LeftFoot.GetVelocity().y + collision.relativeVelocity.y + verticalAssistance + 1f) * (verticalAssistance + .5f), LeftFoot.GetVelocity().z * 1.5f);
            }
            else if (LeftFoot.GetVelocity().magnitude > 5)
            {
                ballV.velocity = new Vector3(LeftFoot.GetVelocity().x * 1.5f, (LeftFoot.GetVelocity().y + collision.relativeVelocity.y + verticalAssistance) * verticalAssistance, LeftFoot.GetVelocity().z * 1.5f);
            } else
            {
                ballV.velocity = new Vector3(LeftFoot.GetVelocity().x * 1.5f, (LeftFoot.GetVelocity().y + collision.relativeVelocity.y) * verticalAssistance, LeftFoot.GetVelocity().z * 1.5f);
            }

        }
        else if (collision.gameObject.tag.Equals("RightFoot"))
        {
            AS.Play();
            if (RightFoot.GetVelocity().magnitude > 8)
            {
                ballV.velocity = new Vector3(RightFoot.GetVelocity().x * 1.5f, (RightFoot.GetVelocity().y + collision.relativeVelocity.y + verticalAssistance + 1f) * (verticalAssistance + .5f), RightFoot.GetVelocity().z * 1.5f);
            }
            else if (RightFoot.GetVelocity().magnitude > 5)
            {
                ballV.velocity = new Vector3(RightFoot.GetVelocity().x * 1.5f, (RightFoot.GetVelocity().y + collision.relativeVelocity.y + verticalAssistance) * verticalAssistance, RightFoot.GetVelocity().z * 1.5f);
            }
            else
            {
                ballV.velocity = new Vector3(RightFoot.GetVelocity().x * 1.5f, (RightFoot.GetVelocity().y + collision.relativeVelocity.y) * verticalAssistance, RightFoot.GetVelocity().z * 1.5f);
            }

        }

    }

    private void OnTriggerEnter(Collider other)
    {
       
    }
}

// ballV.AddForce((LeftFoot.GetVelocity().magnitude * 75),(LeftFoot.GetVelocity().magnitude * 75),(LeftFoot.GetVelocity().magnitude * 75));