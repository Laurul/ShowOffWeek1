using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewJunk : MonoBehaviour
{
    [SerializeField] List<GameObject> junkTypes;
    [SerializeField] GameObject anchor;
    [SerializeField] float countDown = 2.0f;
    [SerializeField] GameObject specialEvent;
    float specialEventCountdown = 15f;
    float aux;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        aux = specialEventCountdown;
        timer = countDown;
    }

    // Update is called once per frame
    void Update()
    {
        specialEventCountdown -= Time.deltaTime;
        if (specialEventCountdown <= 0f)
        {
            Instantiate(specialEvent, new Vector3(anchor.transform.position.x, anchor.transform.position.y, anchor.transform.position.z), Quaternion.identity);
            specialEventCountdown = aux;
        }
       
        timer -= Time.deltaTime;
        if (timer <= 0.0f)
        {
            int index = Random.Range(0, 3);
           // Debug.Log(index);
            Instantiate(junkTypes[index], new Vector3(anchor.transform.position.x, anchor.transform.position.y, anchor.transform.position.z), Quaternion.identity);
            timer = countDown;
        }
    }
}
