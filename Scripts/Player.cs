using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public List<Ability> abilities = new List<Ability>();//list of all your players abilities. You create these in the inspector

    public List<Bar> bars = new List<Bar>();

    public Text xpText;
    public Text lvlText;

    public int playerLevel;
    public float xp;



    private void Start()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        for (int i = 0; i < abilities.Count; i++)
        {
            float currentAmount = abilities[i].abilityAmount;
            float maxAmount = abilities[i].maxAbilityAmount;
            string name = abilities[i].abilityName;

            bars[i].SetValue(currentAmount);
            bars[i].SetMaxValue(maxAmount);
            bars[i].SetTextValue(name);
        }

        xpText.text = "XP: " + xp.ToString();
        lvlText.text = "Level: " + playerLevel.ToString();

    }

    /// <summary>
    /// this is the heart and soul of this entire system. 
    /// this is what takes in a new skill and changes the abilities values
    /// We are using nested for loops, in the origional video each loop was indexed using i, and j
    /// I changed this later to a,and z since i and j look alike
    /// </summary>

    public void AdjustSkill(Skill _skill)//this method takes in a skill
    {
        for (int a = 0; a < abilities.Count; a++)//loop through all of the abilities
        {
            for (int z = 0; z < _skill.effectedTyped.Count; z++)//now loop through all of the effectedTypes list that is sitting in the skill
            {
                if(abilities[a].abilityType == _skill.effectedTyped[z])//check if the ability type == the skill effected type
                {
                    abilities[a].abilityAmount += _skill.effectedAmounts[z];//change the ability by the amount from the effectedAmount list 
                    xp -= _skill.requiredXp;//then reduce your xp
                }
            }
        }

        UpdateUI();//now update your UI

    }



    //------------------------Inventory Item Stuff--------------------

    //public void EquipItem(Skill _skill)
    //{
    //    for (int i = 0; i < abilities.Count; i++)
    //    {
    //        for (int j = 0; j < _skill.effectedTyped.Count; j++)
    //        {
    //            if (abilities[i].abilityType == _skill.effectedTyped[j])
    //            {
    //                abilities[i].abilityAmount += _skill.effectedAmounts[j];
    //            }
    //        }
    //    }

    //    UpdateUI();
    //}

    //public void RemoveEquipedItemSkills(Skill _skill)
    //{
    //    for (int i = 0; i < abilities.Count; i++)
    //    {
    //        for (int j = 0; j < _skill.effectedTyped.Count; j++)
    //        {
    //            if (abilities[i].abilityType == _skill.effectedTyped[j])
    //            {
    //                abilities[i].abilityAmount += (_skill.effectedAmounts[j] * -1);
    //            }
    //        }
    //    }

    //    UpdateUI();
    //}



}
