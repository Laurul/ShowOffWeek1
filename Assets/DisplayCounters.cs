using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCounters : MonoBehaviour
{
    [SerializeField] List<AcceptJunk> junkCounters;
    public List< Text> countersLabel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < countersLabel.Count; i++)
        {
            countersLabel[i].text = junkCounters[i].returnCount().ToString();
        }
    }
}
