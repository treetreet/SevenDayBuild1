using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIManager : MonoBehaviour
{
    [Header("UI Slider")]
    public Slider HealthSlider;
    public Slider ExpSlider;

    private PlayerStatManager playerStat;
    void Awake()
    {
        playerStat = GetComponent<PlayerStatManager>();
    }

    void Start()
    {
        HealthSlider.maxValue = playerStat.maxHealth;
        ExpSlider.maxValue = playerStat.requiredExp;
        UpdateHP();
        UpdateEXP();
    }
    public void UpdateMaxValue()
    {
        HealthSlider.maxValue = playerStat.maxHealth;
        ExpSlider.maxValue = playerStat.requiredExp;
    }
    public void UpdateHP()
    {
        HealthSlider.value = playerStat.currentHealth;
    }
    public void UpdateEXP()
    {
        if(ExpSlider.maxValue > playerStat.currentExp) ExpSlider.value = ExpSlider.maxValue;
        else                                           ExpSlider.value = playerStat.currentExp;
    }

}
