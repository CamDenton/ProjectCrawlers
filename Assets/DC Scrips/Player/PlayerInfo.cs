using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playerInfo : MonoBehaviour {
    
    public string playerName = string.Empty;
    public string playerClass = string.Empty;
    protected int playerCurrentHealth = 0;
    protected int playerMaxHealth = 0; 
    protected int playerArmor = 0;
    protected int playerCurrentStamina = 0;
    protected int playerMaxStamina = 0;
    protected int playerCurrentMana = 0;
    protected int playerMaxMana = 0;


    public playerInfo()
    {

    }

    public playerInfo(string playerName, string playerClass, int playerCurrentHealth, int playerMaxHealth, int playerArmor, int playerCurrentStamina, int playerMaxStamina, int playerCurrentMana, int playerMaxMana)
    {
        this.playerName = playerName;
        this.playerClass = playerClass;
        this.playerCurrentHealth = playerCurrentHealth;
        this.playerMaxHealth = playerMaxHealth;
        this.playerArmor = playerArmor;
        this.playerCurrentStamina = playerCurrentStamina;
        this.playerMaxStamina = playerMaxStamina;
        this.playerCurrentMana = playerCurrentMana;
        this.playerMaxMana = playerMaxMana;
    }

        public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }

    public string ClassName
    {
        get { return playerClass; }

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

    
    
   





    

   

        
    

