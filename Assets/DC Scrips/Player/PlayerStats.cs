using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public Classes playerClassType;
    public string playerName = string.Empty;
    public string playerClass = string.Empty;
    protected int playerCurrentHealth;
    protected int playerMaxHealth = 0;
    protected int playerArmor = 0;
    protected int playerCurrentStamina = 0;
    protected int playerMaxStamina = 0;
    protected int playerCurrentMana = 0;
    protected int playerMaxMana = 0;



    void Start()
    {
        playerMaxHealth = playerClassType.MaxHealth;
        playerCurrentHealth = playerMaxHealth;
        playerArmor = playerClassType.Armor;
        playerCurrentStamina = playerMaxStamina;
        playerMaxStamina = playerClassType.MaxStamina;
        playerCurrentMana = playerMaxMana;
        playerMaxMana = playerClassType.MaxMana;
    }

    private void Update()
    {

    }

    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }

    public string ClassName
    {
        get { return playerClassType.ClassName; }

    }



    public int CurrentHealth
    {
        get { return playerCurrentHealth; }
        set { playerCurrentHealth = value; }
    }

    public int MaxHealth
    {
        get { return playerMaxHealth; }
        set { playerMaxHealth = value; }
    }

    public int Armor
    {
        get { return playerArmor; }
        set { playerArmor = 0; }
    }

    public int CurrentStamina
    {
        get { return playerCurrentStamina; }
        set { playerCurrentStamina = value; }
    }

    public int MaxStamina
    {
        get { return playerMaxStamina; }
        set { playerMaxStamina = value; }
    }

    public int CurrentMana
    {
        get { return playerCurrentMana; }
        set { playerCurrentMana = value; }
    }

    public int MaxMana
    {
        get { return playerMaxMana; }
        set { playerMaxMana = value; }
    }
}

















