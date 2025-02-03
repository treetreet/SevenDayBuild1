using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Game Data/Player")]
public class PlayerData : ScriptableObject
{
    public string characterClass;
    public int level;
    public int health;
    public int speed;
    
    [Header("Skill 1")]
    public int skill1Damage;
    public float skill1Cooldown;

    [Header("Skill 2")]
    public int skill2Damage;
    public float skill2Cooldown;
    public int MaxHealth => health;
}