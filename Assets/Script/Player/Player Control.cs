using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Animate animate;
    private PlayerAttack playerAttack;

    void Awake()
    {
        animate = GetComponent<Animate>();
        playerAttack = GetComponent<PlayerAttack>();
    }
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(moveX, moveY, 0);
        transform.Translate(moveVector.normalized * Time.deltaTime * 5f);

        if(moveX != 0 || moveY != 0)
        {
            animate.moveOn();
        }
        else
        {
            animate.moveOff();
        }

        if(Input.GetKeyDown(KeyCode.J))
        {
            animate.IsAttacked();
            playerAttack.AttackEnemy();
        }
    }
}
