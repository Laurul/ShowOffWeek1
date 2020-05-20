using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean;

public class BateryBehaviour : MonoBehaviour
{
    [SerializeField] Lean.Touch.LeanSelectable leanSelectable;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = GameObject.FindWithTag("Submarine").transform.rotation;
        
        if (leanSelectable.IsSelected == true)
        {
            this.transform.GetComponent<Rigidbody>().isKinematic = true;

        }
        else
        {
            if (this.transform.GetComponent<Rigidbody>().velocity.magnitude < 0.01f)
                this.transform.GetComponent<Rigidbody>().AddForce(-transform.up * 6);
            this.transform.GetComponent<Rigidbody>().isKinematic = false;

        }


    }
}
