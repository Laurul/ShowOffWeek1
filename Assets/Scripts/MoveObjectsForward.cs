using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean;

public class MoveObjectsForward : MonoBehaviour
{
    [SerializeField] bool moving=true;
   [SerializeField] Lean.Touch.LeanSelectable leanSelectable;
    Lean.Touch.LeanFingerDown finger;
    
    
    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
        //  if(Lean.Touch.LeanTouch.Fingers[0]!=null)
        // print( Lean.Touch.LeanTouch.Fingers[0].ScreenPosition.x);
        if (Lean.Touch.LeanTouch.Fingers.Count >0)
        {
            print(Lean.Touch.LeanTouch.Fingers[0].ScreenPosition);
        }

        if (leanSelectable.IsSelected == true)
        {
            moving=false;
            Vector3 mouse = Input.mousePosition;
            Ray castPoint = Camera.main.ScreenPointToRay(new Vector3(Lean.Touch.LeanTouch.Fingers[0].ScreenPosition.x, Lean.Touch.LeanTouch.Fingers[0].ScreenPosition.y,0));
            RaycastHit hit;
            if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))
            {
                if (hit.transform.tag == "water" || hit.transform.tag == "biomass" || hit.transform.tag == "metal")
                    hit.transform.position = Vector3.MoveTowards(transform.position,hit.point,Time.deltaTime*20);// new Vector3( hit.point.x,hit.point.y,-1);
                if (hit.transform.position.z <= 0)
                {
                    hit.transform.position = new Vector3(hit.transform.position.x, hit.transform.position.y, 0);
                }
            }
           

        }
        if (moving == true)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -0.05f));
        }
        if (transform.position.z < -8)
        {
            Destroy(this.gameObject);
        }
    }
}
