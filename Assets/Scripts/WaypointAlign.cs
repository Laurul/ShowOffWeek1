using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointAlign : MonoBehaviour
{
    Quaternion rotTarget;
    [SerializeField] private GameObject nextWaypoint;
    // Start is called before the first frame update
    void Start()
    {
       


    }

    // Update is called once per frame
    void Update()
    {
        rotTarget = Quaternion.LookRotation(nextWaypoint.transform.position - transform.position);
        this.transform.rotation = Quaternion.RotateTowards(transform.rotation, rotTarget, 1000 * Time.deltaTime);
    }
}
