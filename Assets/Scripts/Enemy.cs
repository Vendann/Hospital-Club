using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour
{
    public int HP = 100;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if (HP <= 0)
        {
            animator.SetTrigger("death");
            GetComponent<Collider>().enabled = false;
        }
    }
}
