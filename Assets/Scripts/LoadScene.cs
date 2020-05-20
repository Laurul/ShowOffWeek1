using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] string sceneToLoad;
    entry score;
    private void Awake()
    {
        score = FindObjectOfType<entry>();
    }
    public void LoadCustomScene()
    {

        SceneManager.LoadScene(sceneToLoad);
    }

    public void AddScore()
    {
        score.UpdateScore();
    }

    public void AddName()
    {
        score.UpdateName();
    }

}
