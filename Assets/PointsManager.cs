using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{


    Text textPoints;
    private GameObject[] points;
    private GameObject[] outs;
   
    // Start is called before the first frame update
    void Start()
    {
        textPoints = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        points = GameObject.FindGameObjectsWithTag("Point");
        textPoints.text =  "Points= " + points.Length.ToString();
        
    }
}
