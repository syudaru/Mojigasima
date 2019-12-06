using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class buttonScene : MonoBehaviour
{
    public string ButtonScene;
    public void OnRetry()
    {
        // 「ButtonScene」を自分の読み込みたいscene名に変える
        SceneManager.LoadScene(ButtonScene);
    }
}