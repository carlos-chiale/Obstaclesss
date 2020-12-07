﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallObstacle : MonoBehaviour
{
    public float forceInZ = 0;

    public float timeToApplyForce = 5;

    private GameObject ball;

    private Rigidbody rigidbody;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
        rigidbody = ball.GetComponent<Rigidbody>();
        timer = timeToApplyForce;
        Vector3 vector3 = new Vector3(0, 0, forceInZ);
        rigidbody.AddForce(vector3, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 vector3 = new Vector3(0, 0, forceInZ);
            rigidbody.AddForce(vector3, ForceMode.Impulse);
            timer = timeToApplyForce;
        }
    }
}
