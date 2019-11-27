using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBoundary : MonoBehaviour
{


    public GameObject Ball;
    public Transform spawnPoint;
    public ParticleSystem PS;
    private AudioSource AS;



    // Start is called before the first frame update

    private void Start()
    {
        AS = this.GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
     
            
            
            
             
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Football"))
        {
            if (AS != null) {
                Debug.Log("GOAL");
                AS.Play();
            }
            Destroy(GameObject.FindGameObjectWithTag("Kaboom"));
            GameObject.Destroy(other.gameObject);
            Instantiate(PS);
            PS.transform.position = other.gameObject.transform.position;
            PS.Play();
            Ball.transform.localScale = new Vector3(1, 1.610702f, 1);
            Ball.transform.position = spawnPoint.position;

            Instantiate(Ball, spawnPoint);
        }
    }

}
