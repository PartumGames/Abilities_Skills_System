using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Skill_Slot : MonoBehaviour, IPointerClickHandler
{
    public Skill mySkill;
    private Skills_Manager manager;
    private Player player;

    private Image img;
    private Text nameText;
    private Text lvlText;
    //private Text xpText;//forgot to add this in the video. 

    private Color normalColor;
    public Color selectedColor;//bad name, should be named something like disabled color. 



    public void Init(Skill _mySkill, Skills_Manager _manager, Player _player)//initializes this slot, Skills_Manager calls this method
    {
        mySkill = _mySkill;
        manager = _manager;
        player = _player;

        //grabbing all of our components
        img = GetComponent<Image>();
        nameText = transform.GetChild(0).GetComponent<Text>();
        lvlText = transform.GetChild(1).GetComponent<Text>();
        //xpText = transform.GetChild(2).GetComponent<Text>();

        normalColor = img.color;

        UpdateUI();

    }


    public void UpdateUI()
    {
        img.sprite = mySkill.skillIcon;
        nameText.text = mySkill.skillName;
        lvlText.text = mySkill.requiredLevel.ToString();

        if(player.playerLevel >= mySkill.requiredLevel && player.xp >= mySkill.requiredXp)//check if player has enough xp/levels for this skill
        {
            if (mySkill.beenSelected)//then check if this skill has already been selected
            {
                img.color = selectedColor;//if it has already been selected, then set the img color to the selectedColor
            }
            else
            {
                img.color = normalColor;//if not then set it to the normal color
            }
        }
        else
        {
            img.color = selectedColor;//if player doesn't have enought xp/levels for this skill, set the color to selected [disabled] color
        }


    }


    public void OnPointerClick(PointerEventData eventData)
    {
        //check once again if the player has enough xp/levels, and that this skill has not already been selected
        if(player.playerLevel >= mySkill.requiredLevel && player.xp >= mySkill.requiredXp && !mySkill.beenSelected)
        {
            player.AdjustSkill(mySkill);//this method actually changes the values of the abilities
            mySkill.beenSelected = true;
            manager.UpdateAllSlots();
        }
    }
}
