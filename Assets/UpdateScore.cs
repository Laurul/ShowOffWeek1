using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateScore : MonoBehaviour
{
    [SerializeField] Text scoreText;

    [SerializeField] List<AcceptJunk> containers;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int toAdd = 0;
        
        foreach (AcceptJunk container in containers)
        {
            if (container.returnCollected() == true)
            {
                container.SwitchCollected();
                toAdd += 100;
                score += toAdd;
            }
            
        }
        scoreText.text = "Score: " + score;
    }
}
