﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBehaviour : MonoBehaviour
{

    public SingleFish myManager;
    float speed;
    private GameObject player;
   
    // Use this for initialization
    void Start()
    {
        speed = Random.Range(myManager.minSpeed,
                                myManager.maxSpeed);
        player = GameObject.FindWithTag("Submarine");
        
    }
   
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, Time.deltaTime * speed);
        ApplyRules();
        this.transform.rotation = player.transform.rotation;
    }
    void ApplyRules()
    {
        GameObject[] gos;
        gos = myManager.allFish;

        Vector3 vcentre = Vector3.zero;
        Vector3 vavoid = Vector3.zero;
        float gSpeed = 0.01f;
        float nDistance;
        int groupSize = 0;

        foreach (GameObject go in gos)
        {
            if (go != this.gameObject)
            {
                nDistance = Vector3.Distance(go.transform.position, this.transform.position);
                if (nDistance <= myManager.neighbourDistance)
                {
                    vcentre += go.transform.position;
                    groupSize++;

                    if (nDistance < 1.0f)
                    {
                        vavoid = vavoid + (this.transform.position - go.transform.position);
                    }

                    SingleFish anotherFlock = go.GetComponent<SingleFish>();
                    gSpeed = gSpeed + speed;
                }
            }
        }

        if (groupSize > 0)
        {
            vcentre = vcentre / groupSize;
            speed = gSpeed / groupSize;

            Vector3 direction = (vcentre + vavoid) - transform.position;
            if (direction != Vector3.zero)
                transform.rotation = Quaternion.Slerp(transform.rotation,
                                                      Quaternion.LookRotation(direction),
                                                      myManager.rotationSpeed * Time.deltaTime);

        }
    }
}