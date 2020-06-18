using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaterySpawner : MonoBehaviour
{
    [SerializeField] GameObject objectToSpwan;
    [SerializeField] GameObject container;
    [SerializeField] float countDown = 5.0f;
    GameObject[] g;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.rotation = this.transform.parent.transform.rotation;
	timer=countDown;
    }

    // Update is called once per frame
    void Update()
    {
      
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            GameObject bateryClone =Instantiate(objectToSpwan, new Vector3(this.transform.position.x+ Random.Range(-1f, 1f), this.transform.position.y, this.transform.position.z), this.transform.rotation) as GameObject;
           // bateryClone.transform.position = new Vector3(bateryClone.transform.position.x, bateryClone.transform.position.y, container.transform.position.z);
           
           Destroy(bateryClone,70f);
            bateryClone.transform.parent = transform;
            Rigidbody rb = bateryClone.GetComponent<Rigidbody>();
           rb.AddForce(-transform.up*6);
            bateryClone.transform.parent = transform;
          
            timer = countDown;
        }

        
    }
}
