using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectsOnClick : MonoBehaviour
{
   [SerializeField] private float targetTime = 60.0f;
    private int clickCounter=0;
    [SerializeField] private int numberOfClicksNeeded = 3;
    [SerializeField] int scoreToAdd = 1000;
    private UpdateScore scoreUpdate;
    private GameObject scoreManager;
  //  [SerializeField] Camera cam;
    private bool canStart = false;
    AudioSource audioData;
    

    private RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        scoreManager = GameObject.Find("ScoreManager");
        scoreUpdate = scoreManager.GetComponent<UpdateScore>();
    }

    // Update is called once per frame
    void Update()
    {
        if (targetTime <= 0)
        {
            targetTime = 10.0f;
            clickCounter = 0;
            canStart = false;
        }
        Debug.Log(targetTime);
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
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
        
        
    }

    void timerEnded()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "BigChunk")
                {
                    audioData.Play(0);
                    clickCounter++;
                    if (clickCounter >= numberOfClicksNeeded)
                    {
                        scoreUpdate.AddScore(scoreToAdd);
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
