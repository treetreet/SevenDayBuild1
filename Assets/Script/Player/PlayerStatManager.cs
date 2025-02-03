using System;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

public class PlayerStatManager : MonoBehaviour
{
    enum JobType
    {
        Warrior,
        Tank,
        Archer,
        Mage
    }
    private JobType playerJob = JobType.Warrior;
    private PlayerDatabase playerDatabase;
    private PlayerData playerData;
    private int[] level = new int[4];
    private int currentEXP = 0;
    private int requiredEXP;
    private int currentHP;
    void Awake() 
    {
        playerDatabase = GetComponent<PlayerDatabase>();
        playerData = playerDatabase.warriorData[level[(int)playerJob]];
        //LOAD level & currExp from playerPref
    }
    void Start() 
    {
        requiredEXP = (int)math.pow(2, 7 + level[(int)playerJob]);
        currentHP = playerData.health;
    }
    public void GetEXP(int exp)
    {
        currentEXP += exp;
        /*if(currEXP > needEXP)
        {
            currEXP -= needEXP;
            requiredEXP = (int)math.pow(2, 7 + level[(int)playerJob]);
            level[(int)playerJob]++;
            ChangeJob((int)playerJob);  //레벨업 시 데이터 변경
        }*/
    }
    public void UpdateHP(int healthChange)
    {
        currentHP += healthChange;
        if(currentHP <= 0)
        {
            PlayerDamaged.IsDie();
        }
        if(currentHP > playerData.MaxHealth)
        {
            currentHP = playerData.MaxHealth;
        }
    }    
    public void ChangeJob(int job)
    {
        playerJob = (JobType)job;
        switch (playerJob)
        {
            case JobType.Warrior:
                playerData = playerDatabase.warriorData[level[(int)playerJob]];
                break;
            case JobType.Tank:
                playerData = playerDatabase.tankData[level[(int)playerJob]];
                break;
            case JobType.Archer:
                playerData = playerDatabase.archerData[level[(int)playerJob]];
                break;
            case JobType.Mage:
                playerData = playerDatabase.mageData[level[(int)playerJob]];
                break;
            default:
                Debug.LogError("Unknown job type!");
                return;
        }
    }
    public int currentHealth => currentHP;
    public int maxHealth => playerData.MaxHealth;
    public int currentExp => currentEXP;
    public int requiredExp => requiredEXP;
    public int skill1Damage => playerData.skill1Damage;
    public int skill2Damage => playerData.skill2Damage;
}