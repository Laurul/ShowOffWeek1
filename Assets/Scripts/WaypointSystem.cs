﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaypointSystem : MonoBehaviour
{
    [SerializeField] Transform[] waypoints;
    [SerializeField] public float moveSpeed = 0f;
    [SerializeField] private Slider speedSlider;
    private int waypointIndex=0;
    
    // Start is called before the first frame update
    void Start()
    {
        this.transform.rotation = waypoints[0].transform.rotation;
        speedSlider.GetComponent<Slider>().value=1;
        transform.position = waypoints[waypointIndex].transform.position;
        moveSpeed = speedSlider.GetComponent<Slider>().value;
    }

    // Update is called once per frame
    void Update()
    {
        if(speedSlider.GetComponent<Slider>().value < 1)
        {
            speedSlider.GetComponent<Slider>().value = 1;
        }
        moveSpeed = speedSlider.GetComponent<Slider>().value;

        if (waypointIndex!=waypoints.Length)
        Move();
    }
    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime); ;
        if (transform.position == waypoints[waypointIndex].transform.position)
        {
            waypointIndex += 1;
            this.transform.localRotation = waypoints[waypointIndex].transform.localRotation;
           
             
        }
    }
}
