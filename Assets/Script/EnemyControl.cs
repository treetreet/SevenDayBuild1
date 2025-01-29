using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    //Range & Transform
    public Transform player;  //임시
    private float detectionRange = 11f;
    private float attackRange = 0.6f;

    //Scripts
    private Movement movement;
    private Attack attack;
    private Damaged damaged;

    //Animator
    private Animator animator;


    void Awake()
    {
        animator = GetComponent<Animator>();

        movement = GetComponent<Movement>();
        attack = GetComponent<Attack>();
        damaged = GetComponent<Damaged>();
    }

    void Update() 
    {
        if(Vector3.Distance(player.position, transform.position) < attackRange)
        {
            animator.SetBool("1_Move", false);
            animator.SetTrigger("2_Attack");
            attack.AttackPlayer();
        }
        else if(Vector3.Distance(player.position, transform.position) < detectionRange)
        {
            animator.SetBool("1_Move", true);
            movement.Move(player.position - transform.position);
        }
    }

    public void SetTarget(Transform target)
    {
        player = target;
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "weapon")
        {

        }
    }
}