using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationOvveride : MonoBehaviour
{
   [SerializeField] Animator leverAnim;
    private int direction = 0;
    // Start is called before the first frame update
    private void Awake()
    {
       // leverAnim = GetComponent<Animator>();
    }
  

   public void SetUp()
    {
        direction = 1;
        
        leverAnim.SetBool("up", true);
        leverAnim.Play("Lever_up");
    }

    public void SetDown()
    {
        direction = -1;
        // leverAnim.SetBool("down",true);
        leverAnim.SetBool("up", false);
        leverAnim.Play("Lever_down");
        // leverAnim.SetBool("idle", false);
    }

    public int ReturnDir()
    {
        return direction;
      
    }

    public void ResetDir()
    {
        direction = 0;
    }
    
}
