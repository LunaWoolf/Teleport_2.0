using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventoryItem
{
   
    [SerializeField]
    public string name;
    [SerializeField]
    public string description;
    [SerializeField]
    public int amount;



    public InventoryItem(string name, string description, int amount)
    {
        this.name = name;
        this.description = description;
        this.amount = amount;
    }
}
