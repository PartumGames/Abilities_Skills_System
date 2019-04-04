using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]//------Include this so we can work with this class in the inspector
public class Ability
{
    //player ability...strength, speed, stamina.....
    //these go on your player

    public string abilityName;
    public float abilityAmount;
    public float maxAbilityAmount;

    public AbilityType abilityType;

    public Ability(string abilityName, float abilityAmount, float maxAbilityAmount, AbilityType abilityType)
    {
        this.abilityName = abilityName;
        this.abilityAmount = abilityAmount;
        this.maxAbilityAmount = maxAbilityAmount;
        this.abilityType = abilityType;
    }
}

public enum AbilityType { Strength, Speed, Magic};//---notice this is outside of our class...this is so that all other scripts know what an AbilityType means

