using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootController : MonoBehaviour
{

    private Vector3 last;
    private Vector3 current;
    private Vector3 velocity;
 
    // Start is called before the first frame update
    void Start()
    {
        current = this.transform.position;
        last = current;

    }

    // Update is called once per frame
    void Update()
    {
        current = this.transform.position;
        //Debug.Log("Velocity" + velocity);
        //Debug.Log("current" + current);
        //Debug.Log("last" + last);
        velocity = (current - last) / Time.deltaTime;
        last = current;
    }

    public Vector3 GetVelocity()
    {
        return velocity;
    }
    public string GetTag()
    {
        return this.tag;
    }
}
