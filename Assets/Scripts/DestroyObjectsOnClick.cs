using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectsOnClick : MonoBehaviour
{
   [SerializeField] private float targetTime = 60.0f;
   [SerializeField] private int clickCounter=0;
    private bool canStart = false;
    AudioSource audioData;
    

    private RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(targetTime);
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "BigChunk")
                {
                    canStart = true;
                }
            }
        }
        
            if (canStart == true)
            {
                targetTime -= Time.deltaTime;
                if (targetTime <= 60.0f)
                {
                    timerEnded();
                }
            }
        
        void timerEnded()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.tag == "BigChunk")
                    {
                        audioData.Play(0);
                        clickCounter++;
                        if (clickCounter == 3)
                        {
                            clickCounter = 0;
                            Destroy(hit.transform.gameObject);
                            targetTime = 60f;
                            canStart = false;

                        }
                    }
                }
            }

        }
    }
}
