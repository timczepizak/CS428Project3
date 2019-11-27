using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFoot : MonoBehaviour
{
    public GameObject foot;
    // Start is called before the first frame update
    void Start()
    {

        GameObject child = Instantiate(foot);
        child.transform.parent = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
