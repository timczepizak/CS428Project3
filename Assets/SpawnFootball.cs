using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFootball : MonoBehaviour
{
    public GameObject Ball;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        Ball.transform.localScale = new Vector3(1, 1.610702f, 1);
        Ball.transform.position = spawnPoint.position;

        Instantiate(Ball, spawnPoint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
