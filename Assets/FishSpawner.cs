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
    private int nrWaves = 0;

    [SerializeField] private float timeUp = 0.5f;

    // Start is called before the first frame update
    void Start()
    {





    }

    // Update is called once per frame
    void Update()
    {
        if (nrWaves < nrWavess)
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

        int posI1 = Random.Range(0, 6);
        GameObject fishObjects = Instantiate(fishPrefab, rightSpawnPoints[posI1].transform.position, rightSpawnPoints[posI1].transform.localRotation) as GameObject;
        Debug.Log("PULA");
        int posI2 = Random.Range(0, 6);

        fishObjects.gameObject.GetComponent<FishBehviour>().pos2 = leftSpawnPoints[posI2].transform.position;
        //   fishObjects.gameObject.GetComponent<FishBehviour>().destination = leftSpawnPoints[posI2].transform.position;

    }
}
