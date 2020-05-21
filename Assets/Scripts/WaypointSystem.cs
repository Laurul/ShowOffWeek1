using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaypointSystem : MonoBehaviour
{
    [SerializeField] Transform[] waypoints;
    [SerializeField] public float moveSpeed = 0f;
    [SerializeField] private Slider speedSlider;
    private int waypointIndex=0;
    Quaternion rotTarget;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
        moveSpeed = speedSlider.GetComponent<Slider>().value;
       for(int counter=0; counter < waypoints.Length-1; counter++)
        {
            Debug.Log("PULAAA");
            waypoints[counter].transform.LookAt(waypoints[counter+1].transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
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
            this.transform.LookAt(waypoints[waypointIndex].transform);
           
             
        }
    }
    
}
