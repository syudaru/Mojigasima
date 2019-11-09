using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tagScene : MonoBehaviour
{
    public string sceneGoal;
    public string sceneEnemy;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Goal"))
        {
            SceneManager.LoadScene(sceneGoal);
        }
        if (collision.gameObject.tag == ("Enemy"))
        {
            SceneManager.LoadScene(sceneEnemy);
        }
    }

}
