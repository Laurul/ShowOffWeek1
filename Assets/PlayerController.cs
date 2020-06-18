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
   

}
