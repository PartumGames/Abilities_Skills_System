//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Inventory : MonoBehaviour
//{
//    public List<Inventory_Slot> slots = new List<Inventory_Slot>();
//    public GameObject spacerPanel;
//    public GameObject invSlot;

//    public Holder holder;
//    public Skills_Manager manager;

//    public Item item01;
//    public Item item02;
//    public Item item03;

//    private void Start()
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            GameObject go = Instantiate(invSlot, Vector3.zero, Quaternion.identity);
//            Inventory_Slot slot = go.GetComponent<Inventory_Slot>();
//            slot.Init(null, holder, manager);
//            slots.Add(slot);
//            go.transform.SetParent(spacerPanel.transform);
//        }

//        AddItem(item01, 1);
//        AddItem(item02, 1);
//        AddItem(item03, 1);
//    }


//    public void AddItem(Item _item, int _amnt)
//    {
//        for (int i = 0; i < slots.Count; i++)
//        {
//            if(slots[i].myItem == null)
//            {
//                slots[i].AddItem(_item, _amnt);
//                return;
//            }
//        }
//    }

//}
