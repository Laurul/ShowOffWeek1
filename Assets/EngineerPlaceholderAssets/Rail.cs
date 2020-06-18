using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Rail : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float smoothing=0.2f;
    [SerializeField] Transform finishTarget;
    [SerializeField] UnityEngine.Vector3 offsetCamera;
    UnityEngine.Vector3 translatedPos;

    bool finish = false;

    private void Start()
    {
       
    }
    private void LateUpdate()
    {
       
        if (finish == false)
        {
            translatedPos = transform.position + offsetCamera;
            UnityEngine.Vector3 smoothPosition = UnityEngine.Vector3.Lerp(translatedPos, target.position, smoothing);
            transform.position = smoothPosition;
            transform.LookAt(target);
        }
        else
        {
            // translatedPos = transform.position + offsetCamera;
            // UnityEngine.Vector3 smoothPosition = UnityEngine.Vector3.Lerp(translatedPos, finishTarget.position, smoothing);
            // transform.position = smoothPosition;
          
            transform.rotation = UnityEngine.Quaternion.Slerp(transform.rotation, finishTarget.rotation, smoothing * Time.deltaTime*10);
           transform.position = UnityEngine.Vector3.MoveTowards(transform.position, finishTarget.position, smoothing * Time.deltaTime*20);
           
            
            
           
        }
       
    }

    public void ChangeFinish()
    {
        finish = !finish;
    }
}
