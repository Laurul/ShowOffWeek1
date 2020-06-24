using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class videSwitch : MonoBehaviour
{

    VideoPlayer video;
    string url;
    [SerializeField] AudioSource audioSource;
    void Awake()
    {
        video = GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += CheckOver;


    }

    private void Update()
    {
        if (string.IsNullOrEmpty(url))
        {
            url = System.IO.Path.Combine(Application.streamingAssetsPath, "mv_ending");
        }

        video.url = url;
        video.SetTargetAudioSource(0, audioSource);
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene(5);
    }
}
