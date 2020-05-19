using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCondition : MonoBehaviour
{
    [SerializeField] private GameObject fuelLeft;
    [SerializeField] private GameObject scoreObject;
    public int scoreEnd;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (fuelLeft.transform.gameObject.GetComponent<EnergyBar>().barMeter < 0.01f)
        {
            SceneManager.LoadScene("End");
            scoreEnd = scoreObject.transform.gameObject.GetComponent<UpdateScore>().score;
        }

    }
}
