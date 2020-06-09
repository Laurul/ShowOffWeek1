using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{public void btn_changeScene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
    public void btn_quitGame()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="boundry")
        SceneManager.LoadScene(4);
    }
}
