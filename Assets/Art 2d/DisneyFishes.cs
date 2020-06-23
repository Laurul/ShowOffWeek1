using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisneyFishes : MonoBehaviour
{
    [SerializeField] bool movement = false;
    [SerializeField] float countDown = 1f;
    [SerializeField] private GameObject boundryUp;
    [SerializeField] private GameObject boundryDown;
    private float thrust =0.1f;
    private Rigidbody rb;
    float timer=1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        int roll = Random.Range(0,2);
        if(roll==0) movement = false;
        if (roll == 1) movement = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        
       
           
           
       
        if (movement == true)
        {
            rb.AddForce(transform.up * thrust);
            Debug.Log("SUS");
        }
        if (movement == false)
        {
            rb.AddForce(-transform.up * thrust);

            Debug.Log("Jos");
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == boundryUp) movement = false;
        if (collision.gameObject == boundryDown) movement = true;
    }

}
