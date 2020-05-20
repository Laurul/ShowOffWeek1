using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerResults : MonoBehaviour
{
    [SerializeField] HighScoreTable table;
    entry refference;
    ScoreEntry scoreAndName;
    // Start is called before the first frame update
    void Start()
    {
        refference = FindObjectOfType<entry>();
        scoreAndName = refference.ReturnNameAndScore();
        table.AddEntry(scoreAndName.score, scoreAndName.name);
        table.UpdateTable();
    }

    // Update is called once per frame
    void Update()
    {
        //print("Name: " + scoreAndName.name + " " + "Score: " + scoreAndName.score);
    }
}
