using System.Collections;
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
            GameObject bateryClone =Instantiate(objectToSpwan, new Vector3(this.transform.position.x+ Random.Range(-1f, 1f), this.transform.position.y, this.transform.position.z), this.transform.rotation) as GameObject;
            Destroy(bateryClone,70f);
            Rigidbody rb = bateryClone.GetComponent<Rigidbody>();
            rb.AddForce(-transform.up*6);
            bateryClone.transform.parent = transform;
            countDown = 3.0f;
        }
    }
}
