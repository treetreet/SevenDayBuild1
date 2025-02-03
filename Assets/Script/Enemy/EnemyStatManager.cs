using System;
using Unity.Mathematics;
using UnityEngine;

public class EnemyStatManager : MonoBehaviour
{
    enum EnemyType
    {
        TestUnit
    }
    private EnemyType enemyType;
    private EnemyDatabase enemyDatabase;
    private EnemyData enemyData;
    private EnemyDamaged enemyDamaged;
    private int level = 1; //클리어 레벨 == 몬스터 레벨
    private int currEXP = 0;
    void Awake() 
    {
        enemyDatabase = GetComponent<EnemyDatabase>();
        enemyDamaged = GetComponent<EnemyDamaged>();
        enemyData = enemyDatabase.TestUnit;
        SetData();
    }
    void SetData()
    {
        enemyData.speed += (int)(0.6f * level);
        enemyData.dropExp = 2 * level;
        enemyData.dropGold = level;
    }
    public void IsAttacked(int damage)
    {
        enemyData.health -= damage;
        if(enemyData.health <= 0)
        {
            enemyDamaged.IsDie();
        }
    }

    public int Speed => enemyData.speed;
    public int Damage => enemyData.Damage;
    public float Cooldown => enemyData.Cooldown;
    public int Exp => enemyData.dropExp;
}