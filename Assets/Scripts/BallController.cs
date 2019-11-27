using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public bat theBat;
    private int timer;
    private bool timerSet = false;
    private float timerf = 0.0f;
    public GameObject point;
    public GameObject owt;


    private void Update()
    {

        if (timer >= 60)
        {
            timerf = 0.0f;
            timer = 0;
            timerSet = false;
            this.GetComponent<TrailRenderer>().enabled = false;
        }
        if (timerSet)
        {
            timerf += Time.deltaTime;
            timer = (int)(timerf % 60);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Contains("Destroy"))
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag.Contains("Field"))
        {
            timerSet = true;
           
        }
        else if (collision.gameObject.tag.Contains("Base Hit"))
        {
            Instantiate(point);
            this.gameObject.GetComponent<Collider>().enabled = false;
            Destroy(this.gameObject, 60);
        }
        else if (collision.gameObject.tag.Contains("Double"))
        {
            Instantiate(point);
            Instantiate(point);
            this.gameObject.GetComponent<Collider>().enabled = false;
            Destroy(this.gameObject, 60);
        }
        else if (collision.gameObject.tag.Contains("Triple"))
        {
            Instantiate(point);
            Instantiate(point);
            Instantiate(point);
            this.gameObject.GetComponent<Collider>().enabled = false;
            Destroy(this.gameObject, 60);
        }
        else if (collision.gameObject.tag.Contains("Homerun"))
        {
            Instantiate(point);
            Instantiate(point);
            Instantiate(point);
            Instantiate(point);
            this.gameObject.GetComponent<Collider>().enabled = false;
            Destroy(this.gameObject, 60);
        }
        else if (collision.gameObject.tag.Contains("Foul"))
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag.Contains("Out"))
        {
            Instantiate(owt);
            this.gameObject.GetComponent<Collider>().enabled = false;
            Destroy(this.gameObject, 60);
        }
        else
        {
            theBat = collision.gameObject.GetComponent<bat>();

            this.gameObject.GetComponent<Rigidbody>().velocity = (theBat.velocity2 + -(this.gameObject.GetComponent<Rigidbody>().velocity)) * 2.8f;
            this.gameObject.GetComponent<Rigidbody>().useGravity = true;
            this.gameObject.GetComponent<TrailRenderer>().enabled = true;
            

        }

    }
}