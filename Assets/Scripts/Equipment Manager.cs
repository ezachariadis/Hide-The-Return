using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : Singleton<EquipmentManager> {

    public int itemCount = 10;
    public List<Item> ItemList = new List<Item>();

    public void AddItem(Item item)
    {
        if(ItemList.Count > itemCount)
        {
            Debug.Log("No Space");
            return;
        }

        ItemList.Add(item);
        Debug.Log("You picked: " + item.GetName());
    }

    public void UseItem(int index)
    {
        if (ItemList.Count <= 0)
        {
            return;
        }

        Item tmp = ItemList[index];
        

        if (tmp is Potion)
        {
            Potion tmpPot = (Potion)tmp;
            Statmanager.Instance.ChangeStats(tmpPot.GetPotionStats());
            ItemList.RemoveAt(index);
        }
    }

}
