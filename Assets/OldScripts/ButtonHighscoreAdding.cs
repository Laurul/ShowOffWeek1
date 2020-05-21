using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHighscoreAdding : MonoBehaviour
{
    [SerializeField] InputField name;
    [SerializeField] InputField score;
    [SerializeField] HighScoreTable table;
    [SerializeField] Button button;

    private void Update()
    {
        if (name.text == null || score.text == null)
        {
            button.gameObject.SetActive(false);
        }

        if (name.text != null || score.text != null)
        {
            button.gameObject.SetActive(true);
        }
    }
    public  void AddNewHighScore()
    {
        
        int _score = int.Parse(score.text);
        table.AddEntry(_score, name.text);
        table.UpdateTable();
        name.text = null;
        score.text = null;
    }
}
