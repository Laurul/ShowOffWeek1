using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonar : MonoBehaviour
{
    [SerializeField] GameObject sonarSphere;
    Vector3 temp;
    private float timeLeft = 1.0f;
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

            if (temp.x >= 12f || temp.z >= 12f || temp.y >= 12f)
            {
                temp.x = 0f;
                temp.z = 0f;
                temp.y = 0f;
                timeLeft = 1.0f;
            }
            sonarSphere.gameObject.transform.localScale = temp;
            
        }
       
    }
}
