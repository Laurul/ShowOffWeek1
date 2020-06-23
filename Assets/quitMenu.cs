using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitMenu : MonoBehaviour
{
  public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUIT");
       
    }
}
