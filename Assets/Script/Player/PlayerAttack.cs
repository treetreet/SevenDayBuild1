using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private string thisTag = "Player";
    private PlayerStatManager statManager;

    void Awake()
    {
        statManager = GetComponent<PlayerStatManager>();
    }

    public void AttackEnemy()
    {
        transform.tag = "PlayerAttack1";
    }

    public void EndAttack()
    {
        Debug.Log("EndAttack");
        transform.tag = thisTag;
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        //Attacked
        if(transform.tag == "PlayerAttack1" || transform.tag == "PlayerAttack2"
         && (other.gameObject.tag == "Enemy" || other.gameObject.tag == "EnemyAttack"))
        {
            Debug.Log("Attacked Enemy");
            EnemyDamaged enemyDamaged = other.gameObject.GetComponent<EnemyDamaged>();
            if(transform.tag == "PlayerAttack1") enemyDamaged.OnHit(statManager.skill1Damage);
        }
    }
}
