using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private string thisTag = "Enemy";
    private EnemyStatManager statManager;

    void Awake()
    {
        statManager = GetComponent<EnemyStatManager>();
    }
    public void AttackPlayer()
    {
        transform.tag = "EnemyAttack";
    }

    public void EndAttack()
    {
        transform.tag = thisTag;
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        //Attacked
        if(transform.tag == "EnemyAttack" && (other.gameObject.tag == "Player" || other.gameObject.tag == "PlayerAttack"))
        {
            Debug.Log("Attacked Player");
            PlayerDamaged playerDamaged = other.gameObject.GetComponent<PlayerDamaged>();
            playerDamaged.OnHit(statManager.Damage);
        }
    }
}
