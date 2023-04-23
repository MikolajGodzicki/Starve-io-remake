using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Item
{
    public int id { get; }
    public string name { get; }
    public string description { get; }
    public Sprite sprite { get; }
    public ItemType itemType { get; }

    public Item(int id, 
        string name, 
        string description, 
        Sprite sprite, 
        ItemType itemType)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.sprite = sprite;
        this.itemType = itemType;
    }
}

public enum ItemType {
    Normal,
    Consumable,
    Tool,
    Weapon
}
