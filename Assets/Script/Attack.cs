using UnityEngine;

public class Attack : MonoBehaviour
{
    private string thisTag = "Enemy";

    public void AttackPlayer()
    {
        transform.parent.tag = "EnemyAttack";
    }

    void EndAttack()
    {
        transform.parent.tag = thisTag;
    }
}
