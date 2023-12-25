using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    /// <summary>
    /// �ړ����̃R���C�_�[��obj�ɐG�ꂽ���̏���
    /// </summary>
    /// <param name="other"></param>
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // �G�ꂽobj�̐e���ړ����ɂ���
            other.transform.SetParent(transform);
        }
    }

    /// <summary>
    /// �ړ����̃R���C�_�[��obj���痣�ꂽ���̏���
    /// </summary>
    /// <param name="other"></param>
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // �G�ꂽobjct�̐e���Ȃ���
            other.transform.SetParent(null);
        }
    }
}
