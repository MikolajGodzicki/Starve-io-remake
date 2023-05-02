using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

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
    public int Quantity;

    public Item () { }

    public Item(
        int id, 
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
    public Item(Item item) {
        this.ID = item.ID;
        this.Name = item.Name;
        this.Description = item.Description;
        this.Sprite = item.Sprite;
        this.ItemType = item.ItemType;
        this.ToolSubType = item.ToolSubType;
    }

    public Item Copy() {
        Item copiedItem = CreateInstance<Item>();

        copiedItem.ID = this.ID;
        copiedItem.Name = this.Name;
        copiedItem.Description = this.Description;
        copiedItem.Sprite = this.Sprite;
        copiedItem.ItemType = this.ItemType;
        copiedItem.ToolSubType = this.ToolSubType;

        return copiedItem;
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