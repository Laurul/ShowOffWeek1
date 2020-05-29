using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressScreenLoader : MonoBehaviour
{
    [SerializeField] private Text progressText; 
    [SerializeField] private Slider progressSlider;

    private AsyncOperation operation;
    private Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponentInChildren<Canvas>(true);
        DontDestroyOnLoad(gameObject);
    }

    public void LoadScene(string scene)
    {
        UpdateProgresUI(0);
        canvas.gameObject.SetActive(true);
        StartCoroutine(StartLoad(scene));
    }

    private IEnumerator StartLoad(string scene)
    {
        operation = SceneManager.LoadSceneAsync(scene);

        while (!operation.isDone)
        {
            UpdateProgresUI(operation.progress);
            yield return null;
        }
        UpdateProgresUI(operation.progress);
        operation = null;
        canvas.gameObject.SetActive(false);
    }

    private void UpdateProgresUI(float progressIndicator)
    {
        progressSlider.value = progressIndicator;
        progressText.text = (int)(progressIndicator * 100.0f) + "%";
    }
}
