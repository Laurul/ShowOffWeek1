using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject finish;
    [SerializeField] NavMeshAgent player;
    [SerializeField] GameObject sub;
    Vector3 currentRotation;

    [SerializeField] [Range(0f, 3f)] float lerpTime;
    Quaternion rot;
    Vector3 desiredRotation;
    // Update is called once per frame
    private void Start()
    {
        
        player.SetDestination(finish.transform.position);
    }
    private void Update()
    {
       // sub.transform.position = this.transform.position;
       

        //transform.rotation = rot;
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    rot = other.transform.rotation;
    //   // print("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
    //    desiredRotation = new Vector3(other.transform.eulerAngles.x, other.transform.eulerAngles.y, other.transform.eulerAngles.z);
    //    print(desiredRotation);
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "navmesh")
    //    {
    //        //currentRotation = transform.eulerAngles;
    //        //currentRotation.x = Mathf.Lerp(currentRotation.x, collision.gameObject.transform.eulerAngles.x, Time.deltaTime * 1.0f);
    //        sub.transform.eulerAngles = collision.gameObject.transform.eulerAngles;
    //    }

    //}

}
