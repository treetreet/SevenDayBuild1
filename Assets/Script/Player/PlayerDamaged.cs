using System;
using System.Data;
using UnityEngine;

public class PlayerDamaged : MonoBehaviour
{
    private Animate animate;
    private PlayerStatManager statManager;
    private PlayerUIManager UIManager;
    void Awake()
    {
        animate = GetComponent<Animate>();
        statManager = GetComponent<PlayerStatManager>();
        UIManager = GetComponent<PlayerUIManager>();
    }
    public void OnHit(int value)
    {
        Debug.Log("Hit");
        animate.IsDamaged();
        statManager.UpdateHP(value * -1);
        UIManager.UpdateHP();
        //damaged sound
    }

    public static void IsDie()
    {
        Debug.Log("Player Die!!");
        //player deadSound
        //gameOver UI activeOn
        //destroy all enemy & boss
    }
}