//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.EventSystems;

//public class Inventory_Slot : MonoBehaviour, IPointerClickHandler
//{
//    public Item myItem;
//    private int myAmount;

//    private Image myImage;
//    private Text amntText;


//    private Holder holder;
//    private Skills_Manager manager;

//    public void Init(Item _myitem, Holder _holder, Skills_Manager _manager)
//    {
//        myImage = GetComponent<Image>();
//        amntText = transform.GetChild(0).GetComponent<Text>();

//        myItem = _myitem;
//        manager = _manager;
//        holder = _holder;

//        UpdateUI();
//    }

//    private void UpdateUI()
//    {
//        if (myItem != null)
//        {
//            myImage.sprite = myItem.itemIcon;
//            amntText.enabled = true;
//            amntText.text = myAmount.ToString();
//        }
//        else
//        {
//            myImage.sprite = null;
//            amntText.enabled = false;
//        }
//    }

//    public void AddItem(Item _item, int _amnt)
//    {
//        if(myItem == null)
//        {
//            myItem = _item;
//        }

//        myAmount += _amnt;
//        UpdateUI();
//    }

//    public void OnPointerClick(PointerEventData eventData)
//    {
//        //equipping an item here....ie to hotbar...
//        holder.GiveMeItem(myItem);
//        myItem = null;
//        UpdateUI();
//    }

//}
