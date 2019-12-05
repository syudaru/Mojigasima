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
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void OnRetry()
    {
        audioSource.PlayOneShot(sound1);
        SceneManager.LoadScene(sceneName);
    }
}