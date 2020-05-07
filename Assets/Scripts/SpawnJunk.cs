using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnJunk : MonoBehaviour
{
    [SerializeField] float countDown = 1.0f;
    [SerializeField] List<GameObject> spaceJunk;
    [SerializeField] GameObject rocketContainer;
    [SerializeField] GameObject sonar;
    
    
    private void Start()
    {
        
    }

    private void Update()
    {
        
        if (sonar.gameObject.transform.GetComponent<Sonar>().canSpawn == true)
        {
            int index = Random.Range(0, 3);
            
                Instantiate(spaceJunk[index], new Vector3(gameObject.transform.position.x, rocketContainer.transform.position.y, this.gameObject.transform.position.z), Quaternion.identity);

            


        }
       

        }

    }

