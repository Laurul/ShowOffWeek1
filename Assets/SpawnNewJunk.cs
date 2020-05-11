using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewJunk : MonoBehaviour
{
    [SerializeField] List<GameObject> junkTypes;
    [SerializeField] GameObject anchor;
    [SerializeField] float countDown = 2.0f;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = countDown;
    }

    // Update is called once per frame
    void Update()
    {
       
        timer -= Time.deltaTime;
        if (timer <= 0.0f)
        {
            int index = Random.Range(0, 3);
            Debug.Log(index);
            Instantiate(junkTypes[index], new Vector3(Random.Range(-8, 8), Random.Range(-3, 6), anchor.transform.position.z), Quaternion.identity);
            timer = countDown;
        }
    }
}
