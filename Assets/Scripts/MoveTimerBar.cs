using UnityEngine;

public class MoveTimerBar : MonoBehaviour
{
   [SerializeField] private GameObject timerBar;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void SetSize(float normalizedSize)
    {
        timerBar.transform.localScale = new Vector3(normalizedSize, 1f);
    }
    public float GetXSize()
    {
        return timerBar.transform.localScale.x;
    }
}
