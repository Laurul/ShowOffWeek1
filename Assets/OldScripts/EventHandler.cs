using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    [SerializeField] MoveTimerBar bar;
    [SerializeField] float difficultyTimer = 20.0f;
    [SerializeField] float spawnTimer = 0.3f;
    private float timerCopy;
    public float barMeter = 1f;
    int difficultyLvl = 0;
   
    float increasePerLevel= .00001f;
    float amount = 0.02f;
    // Start is called before the first frame update
    void Start()
    {
        timerCopy = spawnTimer;
    }

    // Update is called once per frame
    void Update()
    {

        if (bar.GetXSize() > 0f)
        {

            difficultyTimer -= Time.deltaTime;
            if (difficultyTimer <= 0f)
            {
                increasePerLevel *=1.5f;
                difficultyTimer = 20.0f;
                amount *= 1.1f;
            }

            spawnTimer -= Time.deltaTime;
            if (spawnTimer > .01f)
            {
                barMeter -= increasePerLevel;
                bar.SetSize(barMeter);
            }
            else
            {
                spawnTimer = timerCopy;
            }
        }
       
    }

    public void TriggerLvlUP()
    {
        barMeter += amount;
        bar.SetSize(barMeter);
    }
}
