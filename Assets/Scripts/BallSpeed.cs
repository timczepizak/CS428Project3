using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeed : MonoBehaviour
{

    public float speed;
    Rigidbody rB;
    Transform T;
    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody>();
        T = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Contains("RightFoot") || collision.gameObject.tag.Contains("LeftFoot"))
        {
            Debug.Log("hitting them footies");
            rB.velocity += this.transform.forward * speed * Time.deltaTime;
        }
    }
}
