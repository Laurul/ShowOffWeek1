using System.Collections.Generic;
using UnityEngine;

public class SpawnTrash : MonoBehaviour
{
    [SerializeField] GameObject typeOfSpawn;
    List<GameObject> spawnPoints;
    List<GameObject> chunks;
    [SerializeField] List<GameObject> objectsToSpawn;
  //  [SerializeField] GameObject sphere;
    int i = 1;

    int posX=3;
    int posY=1;
    int posZ=3;
    int width=2;
    int height=2;
    int depth=2;
    // Start is called before the first frame update
    void Start()
    {
     //   sphere.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        SpawnObj();
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            //SpawnObj();
            
           // sphere.transform.localScale = new Vector3(i+0.1f, i + 0.1f, i + 0.1f);
            i++;

            for(int i = 0; i < 6; i++)
            {
                Vector3 rndPosWithin;
                rndPosWithin = new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f), Random.Range(-2f, 2f));
                rndPosWithin = transform.TransformPoint(rndPosWithin * .5f);
                Instantiate(typeOfSpawn, rndPosWithin, transform.rotation);
            }

          
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
           // sphere.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            i = 1;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            foreach (GameObject biomass in GameObject.FindGameObjectsWithTag("biomass"))
            {
                Destroy(biomass);
            }
            foreach (GameObject water in GameObject.FindGameObjectsWithTag("water"))
            {
                Destroy(water);
            }
        }
    
        
        
    }
    void SpawnObj()
    {

        foreach (Transform child in transform)
        {

            bool collided = child.gameObject.GetComponent<BoundryCollide>().ReturnCollided();
            bool once = child.gameObject.GetComponent<BoundryCollide>().GetOnce();
            if (collided == true && once == false)
            {
                once = true;
                child.gameObject.GetComponent<BoundryCollide>().SetOnce(true);

                Random.InitState(System.DateTime.Now.Millisecond);
                int index = Random.Range(0, objectsToSpawn.Count);
                Instantiate(objectsToSpawn[index], child.position, Quaternion.identity);
            }

        }
    }

  
}
