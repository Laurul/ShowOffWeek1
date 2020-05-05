using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceptJunk : MonoBehaviour
{
    [SerializeField] string _tag;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       if( other.tag == _tag)
        {
            count++;
            Destroy(other.gameObject);
        }
     
    }
    public int returnCount()
    {
        return count;
    }
}
