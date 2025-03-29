using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator animator;
    private float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (animator == null)
        {
            Debug.LogError("Animator�R���|�[�l���g���A�T�C������Ă��܂���I");
            return; // Animator���A�T�C������Ă��Ȃ��ꍇ�͏����𒆒f
        }

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetFloat("horizontal", 0);
            animator.SetFloat("vertical", 1);
            transform.Translate(Vector3.up * speed); // ������Ɉړ�
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetFloat("horizontal", -1);
            animator.SetFloat("vertical", 0);
            transform.Translate(Vector3.left * speed);
        }
        else if (Input.GetKeyDown(KeyCode.Q)) // �U���g���K�[
        {
            animator.SetTrigger("AttackTrigger");
        }
        else
        {
            animator.SetFloat("horizontal", 0);
            animator.SetFloat("vertical", 0);
        }
    }
}

