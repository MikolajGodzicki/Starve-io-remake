using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[CreateAssetMenu(fileName = "Item", menuName = "Create new Item")]
public class Item : ScriptableObject
{
    public int ID;
    public string Name;
    public string Description;
    public Sprite Sprite;
    public ItemType ItemType;
    public ItemToolSubType ToolSubType;
    public int Quantity = 1;

    public Item () { }

    public Item(int id, 
        string name,
        string description,
        Sprite sprite,
        ItemType itemType,
        ItemToolSubType toolSubType) {
        this.ID = id;
        this.Name = name;
        this.Description = description;
        this.Sprite = sprite;
        this.ItemType = itemType;
        this.ToolSubType = toolSubType;
    }
}

public enum ItemType {
    Normal,
    Consumable,
    Tool,
    Weapon
}

public enum ItemToolSubType {
    None,
    Pickaxe,
    Axe,
    Shovel
}

public enum GatherableEntityType {
    Wood,
    Rock,
    Iron,
    Gold
}