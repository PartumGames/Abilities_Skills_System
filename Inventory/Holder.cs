//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class Holder : MonoBehaviour
//{

//    public Inventory inventory;
//    public Player player;

//    public Item weaponItem;
//    public Item chestItem;
//    public Item headItem;

//    public Image weaponImage;
//    public Image chestImage;
//    public Image headImage;

//    public void GiveMeItem(Item _item)
//    {
//        if(_item.itemType == ItemType.Weapon)
//        {
//            HandleWeapon(_item);
//        }

//        if (_item.itemType == ItemType.Chest)
//        {
//            HandleChest(_item);
//        }

//        if (_item.itemType == ItemType.Head)
//        {
//            HandleHead(_item);
//        }
//    }

//    private void HandleWeapon(Item _item)
//    {
//        if(weaponItem != null)
//        {
//            //put it back in inventory
//            inventory.AddItem(weaponItem, 1);
//            //remove all skills from player
//            player.RemoveEquipedItemSkills(weaponItem.skill);
//            Debug.Log("Removed");
//        }

//        //equip the item
//        weaponItem = _item;
//        //add skills to player
//        player.EquipItem(weaponItem.skill);
//        //update the ui
//        weaponImage.sprite = weaponItem.itemIcon;
//        Debug.Log("Added");
//    }

//    private void HandleChest(Item _item)
//    {
//        if (chestItem != null)
//        {
//            inventory.AddItem(chestItem, 1);
//            player.RemoveEquipedItemSkills(chestItem.skill);
//        }
//        chestItem = _item;
//        player.EquipItem(chestItem.skill);
//        chestImage.sprite = chestItem.itemIcon;
//    }

//    private void HandleHead(Item _item)
//    {
//        if (headItem != null)
//        {
//            inventory.AddItem(headItem, 1);
//            player.RemoveEquipedItemSkills(headItem.skill);
//        }
//        headItem = _item;
//        player.EquipItem(headItem.skill);
//        headImage.sprite = headItem.itemIcon;
//    }
//}
