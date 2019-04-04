using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills_Manager : MonoBehaviour
{

    public List<Skill> allSkills = new List<Skill>();//all of the skills your player could ever have
    private List<Skill_Slot> slots = new List<Skill_Slot>();//all of the slots you put on the panel

    public Player player;//your player script...or whatever script handles your abilities

    public GameObject skillsSpacer;//the panel the slot is going to go on
    public GameObject skillSlot;//the skill slot prefab

    private void Start()//adds all of our slots to the panel, and to the list above. You could do all of this by hand with the inspector....but im lazy
    {
        for (int i = 0; i < allSkills.Count; i++)
        {
            GameObject go = Instantiate(skillSlot, Vector3.zero, Quaternion.identity);

            Skill_Slot slot = go.GetComponent<Skill_Slot>();//declar a Skill_Slot, and get it from the gameobject we created above
            slot.Init(allSkills[i], this, player);//initialize that slot

            slots.Add(slot);//add it to the list for later

            go.transform.SetParent(skillsSpacer.transform);//set the partent to a panel. The panel should have a grid layout group component on it already
        }
    }


    public void UpdateAllSlots()//tells each slot to recheck if the player has enough xp/levles for their particular skill
    {
        for (int i = 0; i < slots.Count; i++)
        {
            slots[i].UpdateUI();
        }
    }

}
