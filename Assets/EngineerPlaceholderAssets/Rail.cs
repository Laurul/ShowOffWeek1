using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Rail : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float smoothing=0.2f;
    //[SerializeField] Vector3 offsetCamera;
    private void LateUpdate()
    {
        UnityEngine.Vector3 smoothPosition = UnityEngine.Vector3.Lerp( transform.position,target.position,smoothing);
        transform.position = smoothPosition;
        transform.LookAt(target);
    }
}
