using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] string sceneToLoad;
    entry score;
    private void Awake()
    {
        score = FindObjectOfType<entry>();
        GetComponent<Button>().onClick.AddListener(LoadMainScene);
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

    public void LoadMainScene()
    {
        gameObject.SetActive(false);
        FindObjectOfType<ProgressScreenLoader>().LoadScene(sceneToLoad);
    }
}
