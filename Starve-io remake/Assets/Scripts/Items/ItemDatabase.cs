using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public static ItemDatabase Instance;

    public void Awake() {
        if (Instance == null) {
            Instance = this;
        }
    }

    [Header("All Items")]
    public Item[] items;

    [Header("Items from Gatherable Entities")]
    public ItemPair[] itemPairs;

    public Item GetItemByGatherType(GatherableEntityType type) {
        return itemPairs.First(e => e.type == type).item;
    }
}

[Serializable]
public class ItemPair {
    public GatherableEntityType type;
    public Item item;
}
