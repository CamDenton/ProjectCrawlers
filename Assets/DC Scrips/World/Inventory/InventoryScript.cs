using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryScript : MonoBehaviour {

    public Image[] itemImage = new Image[slots];
    public ItemScript[] items = new ItemScript[slots];
    public const int slots = 4;

    public void Additem( ItemScript itemsToAdd)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if(items[i] == null)
            {
                items[i] = itemsToAdd;
                itemImage[i].enabled = true;
                itemImage[i].sprite = itemsToAdd.spriteImage;
                
                return;
            }
        }
    }

    public void Removeitem(ItemScript itemsToRemove)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == itemsToRemove)
            {
                items[i] = null;
                itemImage[i].sprite = null;
                itemImage[i].enabled = false;
                return;
            }
        }
    }

}
