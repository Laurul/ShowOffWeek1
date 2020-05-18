﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaterySpawner : MonoBehaviour
{
    [SerializeField] GameObject objectToSpwan;
    [SerializeField] float countDown = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;
        if (countDown <= 0f)
        {
            GameObject bateryClone =Instantiate(objectToSpwan, new Vector3(this.transform.position.x+ Random.Range(-8f, 8f), this.transform.position.y, this.transform.position.z), Quaternion.identity) as GameObject;
            Destroy(bateryClone,70f);
            Rigidbody rb = bateryClone.GetComponent<Rigidbody>();
            rb.AddForce(-transform.up*6);
            countDown = 3.0f;
        }
    }
}
