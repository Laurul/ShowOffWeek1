using UnityEngine;
using UnityEngine.UI;

public class entry : MonoBehaviour
{
    ScoreEntry sc;
    // Start is called before the first frame update
    private void Awake()
    {
        sc = new ScoreEntry();
        DontDestroyOnLoad(gameObject);
    }
    public ScoreEntry ReturnNameAndScore()
    {
        return sc;
    }

    public void UpdateName()
    {
       if(sc.name==null)
        sc.name = FindObjectOfType<InputField>().text;
    }
    public void UpdateScore()
    {
        int _score = int.Parse(FindObjectOfType<InputField>().text);
        sc.score = _score;
    }



}
