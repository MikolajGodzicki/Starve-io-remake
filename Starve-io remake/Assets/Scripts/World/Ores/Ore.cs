using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore : MonoBehaviour, IGatherable {
    [SerializeField]
    private OreType type;

    public Item Gather() {
        Item item = new Item();

        return item;
    }
}


