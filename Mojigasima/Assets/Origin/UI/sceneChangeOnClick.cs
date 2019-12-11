using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneChangeOnClick : MonoBehaviour
{
    public string sceneName;
    public AudioClip sound1;
    AudioSource audioSource;
    public bool DontDestroyEnabled = true;
    private float tmpTime = 0;

    // Start is called before the first frame update
    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        if (DontDestroyEnabled)
        {
            // Sceneを遷移してもオブジェクトが消えないようにする
            DontDestroyOnLoad(this);
        }
    }

    public void OnRetry()
    {
        audioSource.PlayOneShot(sound1);
        SceneManager.LoadScene(sceneName);
    }
    
}