using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean;

public class MoveObjects : MonoBehaviour
{
    [SerializeField] int SwitchVersion = 0;
    [SerializeField] bool moving = false;
    [SerializeField] Lean.Touch.LeanTouch _touchScriptVersion;
   private Vector3 mouseOffset;
    private float mouseZCoord;
    
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        if (SwitchVersion == 1)
        {
            mouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

            mouseOffset = gameObject.transform.position - GetMouseWrldPos();
        }
      
        
    }

    private void OnMouseDrag()
    {
        if (SwitchVersion == 1)
        {
            Vector3 pos = GetMouseWrldPos() + mouseOffset;
            transform.position = new Vector3(pos.x, transform.position.y, pos.z);
        }
           
        
    }

    private Vector3 GetMouseWrldPos()
    {
     
            Vector3 mousePos = Input.mousePosition;

            mousePos.z = mouseZCoord;
       
           
        

        return Camera.main.ScreenToWorldPoint(mousePos);
    }
    private void Update()
    {
        if (SwitchVersion == 1)
        {
            _touchScriptVersion.enabled = false;
        }
        if (SwitchVersion == 0)
        {
            _touchScriptVersion.gameObject.SetActive(true);
        }
       if (moving == true)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -0.1f));
        }
        if (transform.position.z < -8)
        {
            Destroy(this.gameObject);
        }
      
    }
}
