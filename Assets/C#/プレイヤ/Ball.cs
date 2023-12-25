using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{

    public Image �Q�[�W;
    float max = 1;
    float min = 0.12f;

    //public string SceneName;

    public FadeScene FadeScene;


    /// <summary>
    /// ��������
    /// </summary>
    private Rigidbody physics = null;

    /// <summary>
    /// ����������
    /// </summary>
    public void Awake()
    {
        this.physics = this.GetComponent<Rigidbody>();
    }

    int jumpCount = 0;
    public Rigidbody rb;

    /// <summary>
    /// ���t���[�����Ƃ̏���
    /// </summary>

    public void Update()
    {
     
      if (jumpCount < 4 && Input.GetMouseButtonDown(0))
      {
            �Q�[�W.fillAmount -= 12 * (max - min) / 100 + min;
            this.Flip(new Vector3(2.5f, 6.3f, 0));
            jumpCount++;

        }

      if (jumpCount < 4 && Input.GetMouseButtonDown(1))
      {
            �Q�[�W.fillAmount -= 12 * (max - min) / 100 + min;
            this.Flip(new Vector3(-2.5f, 6.3f, 0));
            jumpCount++;

        }
    }

    /// �{�[�����͂���
    /// <param name="force"></param>
    public void Flip(Vector3 force)
    {
        // �u�ԓI�ɗ͂������Ă͂���
        this.physics.AddForce(force, ForceMode.Impulse);
    }

    //�Q�[�W��
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            �Q�[�W.fillAmount = 100 * (max - min) / 100 + min;
            jumpCount = 0;
        }
    }

    //���X�|�[��
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RetryBoard"))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            FadeScene.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
