using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject finish;
    [SerializeField] NavMeshAgent player;
    

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
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, lerpTime * Time.deltaTime);
        //transform.rotation = rot;
    }

    private void OnTriggerEnter(Collider other)
    {
        rot = other.transform.rotation;
       // print("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        desiredRotation = new Vector3(other.transform.eulerAngles.x, other.transform.eulerAngles.y, other.transform.eulerAngles.z);
        print(desiredRotation);
    }

}
