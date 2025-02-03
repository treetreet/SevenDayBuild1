using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    //Range & Transform
    public Transform player;  //임시
    private float detectionRange = 11f;
    private float attackRange = 0.6f;

    //Scripts
    private Animator animator;
    private EnemyAttack attack;
    private EnemyDamaged damaged;
    private EnemyMovement movement;
    private EnemyStatManager statManager;

    //CoolTime
    private float lastAttackTime = -1;


    void Awake()
    {
        statManager = GetComponent<EnemyStatManager>();
        movement = GetComponent<EnemyMovement>();
        damaged = GetComponent<EnemyDamaged>();
        attack = GetComponent<EnemyAttack>();
        animator = GetComponent<Animator>();
    }

    void Update() 
    {
        if(Vector3.Distance(player.position, transform.position) < attackRange)
        {
            animator.SetBool("1_Move", false);
            if(Time.realtimeSinceStartup - lastAttackTime >= statManager.Cooldown)
            {
                lastAttackTime = Time.realtimeSinceStartup;
                animator.SetTrigger("2_Attack");
                attack.AttackPlayer();
            }
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
}