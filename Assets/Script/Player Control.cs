using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(moveX, moveY, 0);
        transform.Translate(moveVector.normalized * Time.deltaTime * 5f);

        if(moveX != 0 || moveY != 0)
        {
            animator.SetBool("1_Move", true);
        }
        else
        {
            animator.SetBool("1_Move", false);
        }

        if(Input.GetKeyDown(KeyCode.J))
        {
            animator.SetTrigger("2_Attack");
        }
    }
}
