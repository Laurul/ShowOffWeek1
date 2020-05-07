using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnJunk : MonoBehaviour
{
    [SerializeField] float countDown = 1.0f;
    [SerializeField] List<GameObject> spaceJunk;
    [SerializeField] GameObject rocketContainer;
   
    float timer;
    private void Start()
    {
        timer = countDown;
    }

    private void Update()
    {
        countDown -= Time.deltaTime;
        if (countDown <= 0.0f)
        {
            int index = Random.Range(0, 3);
            
                Instantiate(spaceJunk[index], new Vector3(Random.Range(-4, 4), rocketContainer.transform.position.y, gameObject.transform.position.z), Quaternion.identity);

            countDown = timer;
        }
    
    }
   
}
