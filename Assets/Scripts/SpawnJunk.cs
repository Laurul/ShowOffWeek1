using System.Collections.Generic;
using UnityEngine;

public class SpawnJunk : MonoBehaviour
{
    [SerializeField] float countDown = 3.0f;
    [SerializeField] List<GameObject> spaceJunk;
    [SerializeField] GameObject rocketContainer;
    [SerializeField] GameObject sonar;
    Vector3 spawnPosition;


    private void Start()
    {
        //spawnPosition = Random.onUnitSphere * (planetRadius + characterHeight * 0.5f) + planetPosition;
    }

    private void Update()
    {
        countDown -= Time.deltaTime;
        if (countDown <= 0f)
        {
            spawnPosition = Random.onUnitSphere * (4 + 1.05f * 0.5f) + sonar.transform.position;
            //if (sonar.gameObject.transform.GetComponent<Sonar>().canSpawn == true)
            //{
            int index = Random.Range(0, 3);
            Instantiate(spaceJunk[index], new Vector3(spawnPosition.x, rocketContainer.transform.position.y, spawnPosition.z), Quaternion.identity);
            //Instantiate(spaceJunk[index], new Vector3(gameObject.transform.position.x, rocketContainer.transform.position.y, this.gameObject.transform.position.z), Quaternion.identity);



            //sonar.gameObject.transform.GetComponent<Sonar>().SwitchCanSpawn();


            //}
            countDown = 3.0f;

        }



    }

}


