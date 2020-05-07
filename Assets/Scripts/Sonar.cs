using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonar : MonoBehaviour
{
    [SerializeField] GameObject sonarSphere;
    private Vector3 temp;
    private float timeLeft = 1f;
    public bool canSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
       
        if (timeLeft < 0)
        {
            temp = sonarSphere.gameObject.transform.localScale;
            temp.x += 0.1f;
            temp.z += 0.1f;
            temp.y += 0.1f;
           /*
            *AICI E PROBLEMA SI IN SPAWN JUNK TOT LA bool 
            */ if (temp.x <= 11f && temp.z <= 11f && temp.y <= 11f)
                canSpawn = false;
            if (temp.x >= 12f && temp.z >= 12f && temp.y >= 12f)
            {
                temp.x = 0f;
                temp.z = 0f;
                temp.y = 0f;
                timeLeft = 1f;
                canSpawn = true;
            }
            sonarSphere.gameObject.transform.localScale = temp;
           

        }
       
    }
}
