using System;
using UnityEngine;

public class EnemyDamaged : MonoBehaviour
{
    public GameObject player;
    private EnemyStatManager E_statManager;
    private PlayerStatManager P_statManager;
    private PlayerUIManager P_UIManager;
    void Awake()
    {
        E_statManager = GetComponent<EnemyStatManager>();
        P_statManager = player.GetComponent<PlayerStatManager>();
        P_UIManager = player.GetComponent<PlayerUIManager>();
    }
    public void OnHit(int value)
    {
        Debug.Log("Hit");
        E_statManager.IsAttacked(value);
    }

    public void IsDie()
    {
        Debug.Log("Enemy Die!!");
        P_statManager.GetEXP(E_statManager.Exp);
        P_UIManager.UpdateEXP();
        //enemy sfx
        //enemy deadSound
    }
}