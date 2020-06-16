using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasscript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().overrideSorting = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
