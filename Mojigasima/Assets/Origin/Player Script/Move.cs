using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Move : MonoBehaviour
{

    public float speed = 3;
    public float jump = 5;
    public int hp = 3;
    float vx = 0;
    bool leftflag = false;
    bool pushflag = false;
    bool jumpflag = false;
    bool grounflag = false;
    public bool on_damage = false;
    Rigidbody2D rbody;
    private float totalTime;
    public string sceneName;
    public AudioClip sound1;
    public GameManager GameManager;
    AudioSource audioSource;
    private SpriteRenderer renderer;


    // Start is called before the first frame update
    void Start()
    {
        GameManager.SetPlayerHealthUI(hp);
        rbody = GetComponent<Rigidbody2D>();
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        audioSource = GetComponent<AudioSource>();
        renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        vx = 0;
        if (Input.GetKey("right"))
        {
            vx = speed;
            leftflag = false;
        }
        if (Input.GetKey("left"))
        {
            vx = -speed;
            leftflag = true;
        }
        if (Input.GetKeyDown("space") && grounflag)
        {
            if (pushflag == false)
            {
                jumpflag = true;
                pushflag = true;
            }
        }
        else
        {
            pushflag = false;
        }

        if (on_damage)
        {
            float level = Mathf.Abs(Mathf.Sin(Time.time * 10));
            renderer.color = new Color(1f, 1f, 1f, level);
        }
    }
    void FixedUpdate()
    {

        if (jumpflag)
        {
            jumpflag = false;
            rbody.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }

    }
    void OnTriggerStay2D(Collider2D collision)
    {
        grounflag = true;

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        grounflag = false;
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!on_damage && collision.gameObject.tag == "Enemy")
        {
            hp--;
            GameManager.SetPlayerHealthUI(hp);
            audioSource.PlayOneShot(sound1);
            OnDamageEffect();
        }

        if (collision.gameObject.tag == "Gensoku")
        {
            totalTime += Time.deltaTime;
            speed = 1;
            jump = 2;
            audioSource.PlayOneShot(sound1);

            if (totalTime == 5)
            {
                speed = 5;
                jump = 5;
            }
        }
        if (hp <= 0)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    void OnDamageEffect()
    {
        // ダメージフラグON
        on_damage = true;

        // プレイヤーの位置を後ろに飛ばす
        float s = 100f * Time.deltaTime;
        transform.Translate(Vector3.up * s);

        // プレイヤーのlocalScaleでどちらを向いているのかを判定
        if (transform.localScale.x >= 0)
        {
            transform.Translate(Vector3.left * s);
        }
        else
        {
            transform.Translate(Vector3.right * s);
        }

        // コルーチン開始
        StartCoroutine("WaitForIt");
    }

    IEnumerator WaitForIt()
    {
        // 1秒間処理を止める
        yield return new WaitForSeconds(1);

        // １秒後ダメージフラグをfalseにして点滅を戻す
        on_damage = false;
        renderer.color = new Color(1f, 1f, 1f, 1f);
    }
}

