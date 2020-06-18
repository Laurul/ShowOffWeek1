using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    [SerializeField] MoveTimerBar bar;
    [SerializeField] private GameObject bateryContainer;
    public float barMeter = 1f;
    private float timerCopy;
    [SerializeField] float spawnTimer = 0.3f;
    float increasePerLevel = .0001f;
    [SerializeField] private float ennergyAddAmmount = 100;
    [SerializeField] private GameObject submarineObject;
    [SerializeField] private NavMeshAgent navAgent;
    [SerializeField] private AnimationOvveride leverAnim;
    bool up = false;
    bool down = false;
    float value;

    //[SerializeField] private Slider speedSlider;
    // Start is called before the first frame update
    void Start()
    {
        timerCopy = spawnTimer;
        navAgent.speed = 5;
        value = .00001f;
    }

    // Update is called once per frame
    void Update()
    {
        increasePerLevel = value * navAgent.speed;

        switch (leverAnim.ReturnDir())
        {
            case 1:
                navAgent.speed= 10;
                break;
            case 2:
                navAgent.speed = 15;
                break;   
            case 3:
                navAgent.speed = 20;
                break;
            case 4:
                navAgent.speed = 25;
                break; 
            case 5:
                navAgent.speed = 30;
                break;

            default:
                navAgent.speed = 5;
                break;
        }




        if (bateryContainer.gameObject.transform.GetComponent<AcceptJunk>().returnCount() > 0)
        {
            if (barMeter + ennergyAddAmmount * increasePerLevel > 1f)
            {
                barMeter += 1f - barMeter;
                bateryContainer.gameObject.transform.GetComponent<AcceptJunk>().RecycleJunk(1);
                bar.SetSize(barMeter);
            }
            else
            {
                barMeter += ennergyAddAmmount * increasePerLevel;
                bateryContainer.gameObject.transform.GetComponent<AcceptJunk>().RecycleJunk(1);
                bar.SetSize(barMeter);
            }

        }
        if (bar.GetXSize() > 0f)
        {
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
}