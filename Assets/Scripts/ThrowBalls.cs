using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBalls : MonoBehaviour
{


    public GameObject Ball;
    public float speed;
    private Transform stand;
    private Vector3 standPosition;
    private Vector3 spawnBall;
    private Quaternion qBall;
    private int key;
    private Rigidbody ballspeed;
    
    // Start is called before the first frame update
    void Start()
    {
        stand = this.gameObject.transform;
        standPosition = this.gameObject.transform.position;
        spawnBall = new Vector3(standPosition.x + Convert.ToSingle(.85), standPosition.y + Convert.ToSingle(1.35), standPosition.z);
        qBall = this.gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time % 5 < 1 && key != 1)
        {
            key = 1;
            GameObject BaseBall = Instantiate(Ball, spawnBall, qBall);
            ballspeed = BaseBall.GetComponent<Rigidbody>();
            ballspeed.velocity += BaseBall.transform.right * Time.deltaTime * speed;
        }
        if(Time.time % 5 > 2)
        {
            key = 0;
        }
    }
}
