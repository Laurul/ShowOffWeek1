using UnityEngine;
using UnityEngine.UI;
public class MoveTimerBar : MonoBehaviour
{
   [SerializeField] private Image timerBar;
    Vector3 currentRotation;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void SetSize(float normalizedSize)
    {
        //timerBar.transform.localScale = new Vector3(normalizedSize, 1f);
        timerBar.fillAmount = normalizedSize;

    }
    public float GetXSize()
    {
        return timerBar.transform.localScale.x;
    }
    private void Update()
    {
        
    }

   

}
