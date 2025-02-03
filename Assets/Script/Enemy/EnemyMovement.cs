using TreeEditor;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private EnemyStatManager statManager;
    void Awake()
    {
        statManager = GetComponent<EnemyStatManager>();
    }
    public void Move(Vector3 move)
    {
        if(move.x > 0) transform.localScale = new Vector3(-1,1,1);
        else transform.localScale = new Vector3(1,1,1);
        transform.position += move.normalized * Time.deltaTime * statManager.Speed /5f;
    }
}
