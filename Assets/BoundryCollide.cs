using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundryCollide : MonoBehaviour
{
    bool collide = false;
    bool once = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "boundry")
        {
            collide = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "boundry")
        {
            collide = false;
        }
    }


    public bool ReturnCollided()
    {
        return collide;
    }

    public void SetOnce(bool value)
    {
        once = value;
    }

    public bool GetOnce()
    {
        return once;
    }
}
