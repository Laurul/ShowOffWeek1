using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScreens : MonoBehaviour
{
    [SerializeField] List<GameObject> screens;
    int index = 0;
    // Start is called before the first frame update
   public void NextScreen()
    {
        screens[index].SetActive(false);
        index++;
        screens[index].SetActive(true);
    }
}
