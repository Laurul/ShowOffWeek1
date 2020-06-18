using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteEntry : MonoBehaviour
{
    private entry entry;
    private EndCondition endCondition;
    // Start is called before the first frame update
    void Start()
    {
        entry = FindObjectOfType<entry>();
        endCondition = FindObjectOfType<EndCondition>();
    }

    public void DestroyRedundantObjects()
    {
        Destroy(endCondition.gameObject);
            Destroy(entry.gameObject);
        
    }
}
