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
        if(direction<5)
        direction++;
        leverAnim.SetInteger("count", direction);
       
       // leverAnim.SetBool("up", true);
       // leverAnim.Play("Lever_up");
    }

    public void SetDown()
    {
        if(direction>0)
        direction --;
        leverAnim.SetInteger("count", direction);
        // leverAnim.SetBool("down",true);
        // leverAnim.SetBool("up", false);
        // leverAnim.Play("Lever_down");
        // leverAnim.SetBool("idle", false);
    }

    public int ReturnDir()
    {
        return direction;
      
    }

    public void SetDir()
    {
        direction = 0;
    }
    
}
