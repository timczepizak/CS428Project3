using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GivePoints : MonoBehaviour
{
    public GameObject point;

    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag.Contains("Soccer") || other.gameObject.tag.Contains("Football"))
        {
            Instantiate(point);
          
        }
        
    }
    
}
