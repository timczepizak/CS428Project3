using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakePointAway : MonoBehaviour
{

    private GameObject point;
    private GameObject[] points;
    private int counter = 0;
    public Material color1;
    public Material color2;
    public Material color3;
    public Material color4;
    public Material color5;
    public Material color6;
    public GameObject Right;
    public GameObject Left;
    private MeshRenderer RightFoot;
    private MeshRenderer LeftFoot;
    public ParticleSystem White1;
    public ParticleSystem White2;
    public ParticleSystem Red1;
    public ParticleSystem Red2;
    public ParticleSystem Orange1;
    public ParticleSystem Orange2;
    public ParticleSystem Black1;
    public ParticleSystem Black2;
    public ParticleSystem Purple1;
    public ParticleSystem Purple2;
    public ParticleSystem Blue1;
    public ParticleSystem Blue2;

    // Start is called before the first frame update
    void Start()
    {
        RightFoot = Right.GetComponent<MeshRenderer>();
        LeftFoot = Left.GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        points = GameObject.FindGameObjectsWithTag("Point");
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log(counter);
        if (other.gameObject.tag.Contains("LeftFoot") || other.gameObject.tag.Contains("RightFoot"))
        {
            if (counter >= 5)
            {
                //White
                White1.Play();
                White2.Play();
                LeftFoot.material = color1;
                RightFoot.material = color1;
                Destroy(points[0]);
                counter = 0;
            }
            else
            {
                if(counter == 0)
                {
                    //Orange
                    Orange1.Play();
                    Orange2.Play();
                    LeftFoot.material = color2;
                    RightFoot.material = color2;
                }
                else if(counter == 1)
                {
                    //Blue
                    Blue1.Play();
                    Blue2.Play();
                    LeftFoot.material = color3;
                    RightFoot.material = color3;
                }
                else if(counter == 2)
                {
                    //Purple
                    Purple1.Play();
                    Purple2.Play();
                    LeftFoot.material = color4;
                    RightFoot.material = color4;
                }
                else if(counter == 3)
                {
                    //Red
                    Red1.Play();
                    Red2.Play();
                    LeftFoot.material = color5;
                    RightFoot.material = color5;
                }
                else if(counter == 4)
                {
                    //Black
                    Black1.Play();
                    Black2.Play();
                    LeftFoot.material = color6;
                    RightFoot.material = color6;
                }
                counter++;
            }
        }
    }

}
