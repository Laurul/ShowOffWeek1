using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float speed;
    private Rigidbody rb;

    void Start()
    {
        
    }


    void FixedUpdate()
    {
       
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal*Time.deltaTime, 0.0f, moveVertical * Time.deltaTime);

        transform.Translate(movement);
    }
}
