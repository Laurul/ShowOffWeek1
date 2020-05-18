using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBar : MonoBehaviour
{
    [SerializeField] MoveTimerBar bar;
    [SerializeField] private GameObject bateryContainer;
    public float barMeter = 1f;
    private float timerCopy;
    [SerializeField] float spawnTimer = 0.3f;
    float increasePerLevel = .0001f;
    [SerializeField] private float ennergyAddAmmount = 100;
    // Start is called before the first frame update
    void Start()
    {
        timerCopy = spawnTimer;
    }

    // Update is called once per frame
    void Update()
    {if (bateryContainer.gameObject.transform.GetComponent<BateryAccept>().counter>0)
        {
            if (barMeter + ennergyAddAmmount * increasePerLevel > 1f)
            {
                barMeter += 1f - barMeter;
                bateryContainer.gameObject.transform.GetComponent<BateryAccept>().counter--;
                bar.SetSize(barMeter);
            }
            else
            {
                barMeter += ennergyAddAmmount * increasePerLevel;
                bateryContainer.gameObject.transform.GetComponent<BateryAccept>().counter--;
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
