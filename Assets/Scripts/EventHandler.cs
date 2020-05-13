using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    [SerializeField] MoveTimerBar bar;
    [SerializeField] float timer = 0.3f;
    private float timerCopy;
    public float time = 1f;
    int difficultyLvl = 0;
    [SerializeField] float difficultyTimer = 20.0f;
    float increasePerLevel= .0001f;
    float amount = 0.02f;
    // Start is called before the first frame update
    void Start()
    {
        timerCopy = timer;
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
                amount *= 2.5f;
            }

            timer -= Time.deltaTime;
            if (timer > .01f)
            {
                time -= increasePerLevel;
                bar.SetSize(time);
            }
            else
            {
                timer = timerCopy;
            }
        }
       
    }

    public void TriggerLvlUP()
    {
        time += amount;
        bar.SetSize(time);
    }
}
