using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BateryAccept : MonoBehaviour
{
    [SerializeField] private GameObject textObject;
    public int counter=0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textObject.GetComponent<UnityEngine.UI.Text>().text = counter.ToString();

    }
    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag =="batery")
        {
            counter = counter + 1;
            textObject.GetComponent<UnityEngine.UI.Text>().text = counter.ToString();
            Destroy(collision.gameObject);

        }
    }
}
