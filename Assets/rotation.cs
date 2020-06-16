using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    [SerializeField] GameObject objToRotate;
    [SerializeField] GameObject navmesh;
    [SerializeField] GameObject target;
    // Start is called before the first frame update
    RaycastHit hit;
    Vector3 theRay;
    // Update is called once per frame

    private void OnCollisionEnter(Collision collision)
    {

        //objToRotate.transform.eulerAngles = collision.gameObject.transform.eulerAngles;
        //if (collision.gameObject.tag == "navmesh")
        //{

        //Vector3 currentRotation = objToRotate.transform.eulerAngles;
        //currentRotation.x = Mathf.Lerp(currentRotation.x, collision.gameObject.transform.eulerAngles.x, Time.deltaTime * 1.0f);
        //objToRotate.transform.eulerAngles = collision.gameObject.transform.eulerAngles;
        // }

    }

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "navmesh")
        {
            // print(other.gameObject.name);
            //Vector3 currentRotation = objToRotate.transform.eulerAngles;
            //currentRotation.x = Mathf.Lerp(currentRotation.x, other.gameObject.transform.eulerAngles.x, Time.deltaTime * 1.0f);
            // objToRotate.transform.rotation = Quaternion.Slerp(objToRotate.transform.rotation, other.gameObject.transform.rotation, Time.deltaTime * 1f);
          
            target.transform.position = other.gameObject.transform.position;
          
            target.transform.eulerAngles = other.gameObject.transform.eulerAngles;
            target.transform.position = new Vector3(target.transform.position.x, target.transform.position.y + 2, target.transform.position.z);
        }

    }

    private void Update()
    {
      //  Align();
         objToRotate.transform.LookAt(target.transform);
    }

    private void Align()
    {
        theRay = -navmesh.transform.up;

        if (Physics.Raycast(new Vector3(navmesh.transform.position.x, navmesh.transform.position.y, navmesh.transform.position.z),theRay, out hit, 20))
        {
            Quaternion targetRotation = Quaternion.FromToRotation(navmesh.transform.up, hit.normal) * navmesh.transform.parent.rotation;

            navmesh.transform.rotation = Quaternion.Lerp(navmesh.transform.rotation, targetRotation, Time.deltaTime / 0.15f);
            //if (objToRotate.transform.rotation.x < 0)
            //{
               
            //    objToRotate.transform.rotation = objToRotate.transform.rotation*Quaternion.Euler(-objToRotate.transform.rotation.x, objToRotate.transform.rotation.y, objToRotate.transform.rotation.z);
                
            //}
        }
    }

    public void GoUp()
    {
        this.transform.position = new Vector3(this.transform.position.x + 2, this.transform.position.y, this.transform.position.z);
    }
    public void GoDown()
    {
        this.transform.position = new Vector3(this.transform.position.x - 2, this.transform.position.y, this.transform.position.z);
    }
}
