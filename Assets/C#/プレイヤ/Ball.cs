using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{

    public Image ゲージ;
    float max = 1;
    float min = 0.12f;

    //public string SceneName;

    public FadeScene FadeScene;


    /// <summary>
    /// 物理剛体
    /// </summary>
    private Rigidbody physics = null;

    /// <summary>
    /// 初期化処理
    /// </summary>
    public void Awake()
    {
        this.physics = this.GetComponent<Rigidbody>();
    }

    int jumpCount = 0;
    public Rigidbody rb;

    /// <summary>
    /// 毎フレームごとの処理
    /// </summary>

    public void Update()
    {
     
      if (jumpCount < 4 && Input.GetMouseButtonDown(0))
      {
            ゲージ.fillAmount -= 12 * (max - min) / 100 + min;
            this.Flip(new Vector3(2.5f, 6.3f, 0));
            jumpCount++;

        }

      if (jumpCount < 4 && Input.GetMouseButtonDown(1))
      {
            ゲージ.fillAmount -= 12 * (max - min) / 100 + min;
            this.Flip(new Vector3(-2.5f, 6.3f, 0));
            jumpCount++;

        }
    }

    /// ボールをはじく
    /// <param name="force"></param>
    public void Flip(Vector3 force)
    {
        // 瞬間的に力を加えてはじく
        this.physics.AddForce(force, ForceMode.Impulse);
    }

    //ゲージ回復
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ゲージ.fillAmount = 100 * (max - min) / 100 + min;
            jumpCount = 0;
        }
    }

    //リスポーン
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RetryBoard"))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            FadeScene.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
