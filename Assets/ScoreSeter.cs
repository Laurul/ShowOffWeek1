using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSeter : MonoBehaviour
{
     private GameObject scorePull;
    // Start is called before the first frame update
    void Start()
    {
        scorePull = GameObject.FindGameObjectWithTag("ScoreGlobal");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.GetComponent<Text>().text = "Score : " + scorePull.transform.GetComponent<EndCondition>().scoreEnd.ToString();
    }
}
