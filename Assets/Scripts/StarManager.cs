using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class StarManager : MonoBehaviour
{
    [SerializeField] public int passScore;
    [SerializeField] private GameObject star1;
    [SerializeField] private GameObject star2;
    [SerializeField] private GameObject star3;
    private GameObject scoreObject;
    [SerializeField]private bool isFinished=false;
    // Start is called before the first frame update
    void Start()
    {scoreObject = GameObject.FindGameObjectWithTag("ScoreGlobal");
        passScore = scoreObject.transform.gameObject.GetComponent<EndScreenCondition>().scoreEnd;
        star1.gameObject.SetActive(false);
        star2.gameObject.SetActive(false);
        star3.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isFinished==true)
        {
            if (passScore >= 1 && passScore <= 100)
            { star1.gameObject.SetActive(true); }
            if (passScore >= 101 && passScore <= 300)
            {
                star1.gameObject.SetActive(true);
                star2.gameObject.SetActive(true);
            }
            if (passScore >= 301)
            {
                star1.gameObject.SetActive(true);
                star2.gameObject.SetActive(true);
                star3.gameObject.SetActive(true);
            }
        }
    }
}
