using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateScore : MonoBehaviour
{
    [SerializeField] Text scoreText;
    entry refference;

    [SerializeField] List<AcceptJunk> containers;
    public int score = 0;
    // Start is called before the first frame update
    void Awake()
    {
        refference = FindObjectOfType<entry>();

    }

    // Update is called once per frame
    void Update()
    {
        if (refference != null)
            refference.UpdateScore(score);
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
    public void AddScore(int value)
    {
        score += value;
    }
}