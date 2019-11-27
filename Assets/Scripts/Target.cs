using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public string spotType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (spotType.Contains("Both"))
        {
            if (collision.gameObject.tag.Contains("RightFoot") || collision.gameObject.tag.Contains("LeftFoot"))
            {
                Renderer rend = GetComponent<Renderer>();
                rend.material.color = Color.green;

                Debug.Log("Its Goin");
            }
        }
        else if (spotType.Contains("Right"))
        {
            if (collision.gameObject.tag.Contains("RightFoot"))
            {
                Renderer rend = GetComponent<Renderer>();
                rend.material.color = Color.green;

                
            }
            else if (collision.gameObject.tag.Contains("LeftFoot"))
            {
                Renderer rend = GetComponent<Renderer>();
                rend.material.color = Color.red;

            }
        }
        else if (spotType.Contains("Left"))
        {
            if (collision.gameObject.tag.Contains("LeftFoot"))
            {
                Renderer rend = GetComponent<Renderer>();
                rend.material.color = Color.green;


            }
            else if (collision.gameObject.tag.Contains("RightFoot"))
            {
                Renderer rend = GetComponent<Renderer>();
                rend.material.color = Color.red;

            }
        }
    }
 
}
