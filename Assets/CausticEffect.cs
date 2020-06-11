using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CausticEffect : MonoBehaviour
{
    [SerializeField] List<Texture2D> causticFrames;
    [SerializeField]float fps = 15f;

    int index;
    Projector projector;
    // Start is called before the first frame update
    void Start()
    {
        projector = GetComponent<Projector>();
        CausticAnimation();
        InvokeRepeating("CausticAnimation", 1 / fps, 1 / fps);
    }

    void CausticAnimation()
    {
        projector.material.SetTexture("_ShadowTex", causticFrames[index]);
        index = (index + 1) % causticFrames.Count;
    }
}
