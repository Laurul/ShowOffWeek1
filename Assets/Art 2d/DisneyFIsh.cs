using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisneyFIsh : MonoBehaviour
{
   [SerializeField] private bool movement = false;
    private Rigidbody rb;
   [SerializeField] private float thrust = 10.0f;
    float timer;
    [SerializeField]private int countdown=3;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            movement =! movement;
            timer = countdown;
        }
            if (movement==false)
            rb.AddForce(transform.up * thrust);
         if (movement == true)
            rb.AddForce(-transform.up * thrust);
    }
}
