//TO DO: LIST IS NO BIGGER THAN 10 ENTRIES. LIST
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreTable : MonoBehaviour
{
    [SerializeField] private Transform entryContainer;
    [SerializeField] private Transform entryTemplate;
    [SerializeField] float offset = 10f;
    //List<ScoreEntry> highScoresEntries;
    List<Transform> highScoreTransformList;

    private void Awake()
    {
        highScoreTransformList = new List<Transform>();
        entryTemplate.gameObject.SetActive(false);
        //highScoresEntries = new List<ScoreEntry>();
       // AddEntry(3213, "HAL9000");

        //string jsonString = PlayerPrefs.GetString("highscoreTable");
        //Highscores highscores =  JsonUtility.FromJson<Highscores>(jsonString);

        //for(int i = 0; i < highscores.highscoreEntries.Count; i++)
        //{
        //    for (int j=i+1; j < highscores.highscoreEntries.Count; j++)
        //    {
        //        if (highscores.highscoreEntries[j].score > highscores.highscoreEntries[i].score)
        //        {
        //            var aux = highscores.highscoreEntries[i];
        //            highscores.highscoreEntries[i] = highscores.highscoreEntries[j];
        //            highscores.highscoreEntries[j] = aux;
        //        }
        //    }
        //}


        //foreach(ScoreEntry highscoreEntry in highscores.highscoreEntries)
        //{
        //    CreateHighScoreEntry(highscoreEntry, entryContainer, highScoreTransformList);
        //}

        UpdateTable();
    }


    public void AddEntry(int _score, string _name)//use this when you want to add a new highscore to the list
    {
        //Create score entry
        ScoreEntry scoreEntry = new ScoreEntry { score = _score, name = _name };

        //Load saved scores
        string jsonString = PlayerPrefs.GetString("highscoreTable");

        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);

        //Add new entry to highscores
        highscores.highscoreEntries.Add(scoreEntry);

        //Save updated score table
        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("highscoreTable",json);
        PlayerPrefs.Save();
    }

    

    private void CreateHighScoreEntry(ScoreEntry hishcoreEntry, Transform container, List<Transform> transformLists)
    {
        Transform entry = Instantiate(entryTemplate, container);
        RectTransform entryRect = entry.GetComponent<RectTransform>();
        
        entryRect.anchoredPosition = new Vector2(0, transformLists.Count * -offset);
        entry.gameObject.SetActive(true);

        int rank = transformLists.Count + 1;
        string rankString;
        switch (rank)
        {


            case 1: rankString = "1st"; break;
            case 2: rankString = "2nd"; break;
            case 3: rankString = "3rd"; break;
            default: rankString = rank + "th"; break;
        }


        int score = hishcoreEntry.score;
        string name = hishcoreEntry.name;


        entry.GetChild(0).GetComponent<Text>().text = rankString;
        entry.GetChild(1).GetComponent<Text>().text = score.ToString();
        entry.GetChild(2).GetComponent<Text>().text = name;

        transformLists.Add(entry);

    }


    public void UpdateTable()
    {
        foreach (Transform t in highScoreTransformList)
        {

            Destroy(t.gameObject);
        }
        highScoreTransformList.Clear();

        string jsonString = PlayerPrefs.GetString("highscoreTable");
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);
        if (highscores != null)
        {
            for (int i = 0; i < highscores.highscoreEntries.Count; i++)
            {
                for (int j = i + 1; j < highscores.highscoreEntries.Count; j++)
                {
                    if (highscores.highscoreEntries[j].score > highscores.highscoreEntries[i].score)
                    {
                        var aux = highscores.highscoreEntries[i];
                        highscores.highscoreEntries[i] = highscores.highscoreEntries[j];
                        highscores.highscoreEntries[j] = aux;
                    }
                }
            }
            foreach (ScoreEntry highscoreEntry in highscores.highscoreEntries)
            {
                CreateHighScoreEntry(highscoreEntry, entryContainer, highScoreTransformList);
            }
        }



        
    }

    private void Update()
    {
        string jsonString = PlayerPrefs.GetString("highscoreTable");

        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);
        if (highscores == null)
        {
            print(" null");
            string json = JsonUtility.ToJson(new Highscores());
            PlayerPrefs.SetString("highscoreTable", json);
            PlayerPrefs.Save();
        }
        else print("json not null");
    }
}
