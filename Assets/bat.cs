using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bat : MonoBehaviour
{
    public Vector3 velocity2;
    public Vector3 lastPosition;
    // Start is called before the first frame update
    void Start()
    {
        lastPosition = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
        velocity2 = (this.gameObject.GetComponent<Transform>().position - lastPosition) / Time.deltaTime;
        lastPosition = this.gameObject.GetComponent<Transform>().position;
    }

}
