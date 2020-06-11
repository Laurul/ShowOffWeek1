using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCameraHeight : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] GameObject startButton;
    // Start is called before the first frame update
    void Start()
    {
        startButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (cam.transform.position.y <= -26)
        {
            startButton.SetActive(true);
        }
    }
}
