using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatherableEntity : MonoBehaviour, IGatherable {
    [SerializeField]
    private GatherableEntityType type;

    public Item Gather() {
        Item item = new Item();

        return item;
    }
}


