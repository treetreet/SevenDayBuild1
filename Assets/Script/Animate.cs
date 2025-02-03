using UnityEngine;

public class Animate : MonoBehaviour
{
    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void moveOn()
    {
        animator.SetBool("1_Move", true);
    }
    public void moveOff()
    {
        animator.SetBool("1_Move", false);
    }
    public void IsDamaged()
    {
        animator.SetTrigger("3_Damaged");
    }
    public void IsAttacked()
    {
        animator.SetTrigger("2_Attack");
    }
}
