using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] rightSpawnPoints;
    [SerializeField] private GameObject[] leftSpawnPoints;
     private GameObject fishObjects;
    [SerializeField] private GameObject fishPrefab;
    [SerializeField] private int nrWavess = 6;
    private int nrWaves=0;

    [SerializeField]private float timeUp = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
      




    }

    // Update is called once per frame
    void Update()
    {if (nrWaves < nrWavess)
        {
            timeUp -= Time.deltaTime;
            if (timeUp < 0)
            {
                SpawnFishes(1);
                timeUp = 0.5f;
                nrWaves++;
            }
        }
    }
    private void SpawnFishes(int nrFishess)
    {
        for (int i = 0; i < nrFishess; i++)
        {
            int posI1 = Random.Range(0, 6);
            GameObject fishObjects= Instantiate(fishPrefab, rightSpawnPoints[posI1].transform.localPosition  , rightSpawnPoints[posI1].transform.localRotation, this.transform) as GameObject;
           
           int posI2 = Random.Range(0, 6);
          
           fishObjects.gameObject.GetComponent<FishBehviour>().pos2 = leftSpawnPoints[posI2].transform.position;
         //   fishObjects.gameObject.GetComponent<FishBehviour>().destination = leftSpawnPoints[posI2].transform.position;
        }
    }
}
