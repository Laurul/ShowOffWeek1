using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarManager : MonoBehaviour
{
    [SerializeField] private int passScore;
    [SerializeField] private GameObject star1;
    [SerializeField] private GameObject star2;
    [SerializeField] private GameObject star3;
    [SerializeField]private bool isFinished=false;
    // Start is called before the first frame update
    void Start()
    {
        star1.gameObject.SetActive(false);
        star2.gameObject.SetActive(false);
        star3.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isFinished==true)
        {
            if (passScore >= 1 && passScore <= 10)
            { star1.gameObject.SetActive(true); }
            if (passScore >= 11 && passScore <= 30)
            {
                star1.gameObject.SetActive(true);
                star2.gameObject.SetActive(true);
            }
            if (passScore >= 31)
            {
                star1.gameObject.SetActive(true);
                star2.gameObject.SetActive(true);
                star3.gameObject.SetActive(true);
            }
        }
    }
}
