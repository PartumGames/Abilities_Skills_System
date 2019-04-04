using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Skill : ScriptableObject
{
    //these are what change your abilities

    public string skillName;
    public Sprite skillIcon;

    public int requiredLevel;

    public float requiredXp;

    public List<AbilityType> effectedTyped = new List<AbilityType>();
    public List<float> effectedAmounts = new List<float>();

    public bool beenSelected = false;

}
