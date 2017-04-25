using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightClass : playerInfo {

 public KnightClass() : base (string.Empty, "Knight", 100, 100, 0, 100, 100, 10, 10)
    {

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
