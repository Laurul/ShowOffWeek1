using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    [SerializeField] GameObject objToRotate;
    [SerializeField] GameObject navmesh;
    [SerializeField] GameObject target;
   


    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "navmesh")
        {
           

           
        }

    }

   

   
}
