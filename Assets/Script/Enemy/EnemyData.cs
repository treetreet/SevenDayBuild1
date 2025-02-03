using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Game Data/Enemy")]
public class EnemyData : ScriptableObject
{
    [Header("Class")]
    public string characterClass;
    [Header("Stats")]
    public int health;
    public int speed;
    [Header("Drops")]
    public int dropExp;
    public int dropGold;
    [Header("Skill")]
    public int Damage;
    public float Cooldown;
}