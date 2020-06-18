using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
  [SerializeField]  Rail playerRail;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "finish"&&other.name=="END")
        {
            playerRail.ChangeFinish();
            //SceneManager.LoadScene("HighScorePrototype");
        }
        if (other.tag == "finish" && other.name != "END")
        {
           
            SceneManager.LoadScene(4);
        }
        
    }
}
