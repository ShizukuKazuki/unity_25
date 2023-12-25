using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalParticle : MonoBehaviour
{
    [SerializeField]
    [Tooltip("����������G�t�F�N�g(�p�[�e�B�N��)")]
    private ParticleSystem particle;

    /// <summary>
    /// �Փ˂�����
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter(Collider other)
    {
        // �����������肪"Player"�^�O�������Ă�����
        if (other.gameObject.tag == "Player")
        {
            // �p�[�e�B�N���V�X�e���̃C���X�^���X�𐶐�����B
            ParticleSystem newParticle = Instantiate(particle);
            // ���������p�[�e�B�N����position���v���C���[�Ɠ����ɂ���B
            newParticle.transform.position = other.gameObject.transform.position;
            // ���������p�[�e�B�N�����v���C���[�̎q�I�u�W�F�N�g�Ƃ���B
            newParticle.transform.parent = other.gameObject.transform;
            // �p�[�e�B�N���𔭐�������B
            newParticle.Play();
            // �C���X�^���X�������p�[�e�B�N���V�X�e����GameObject���폜����B(�C��)
            // ����������newParticle�����ɂ���ƃR���|�[�l���g�����폜����Ȃ��B
            Destroy(newParticle.gameObject, 5.0f);
        }
    }
}
