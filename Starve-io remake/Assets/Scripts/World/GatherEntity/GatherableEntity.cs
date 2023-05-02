using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatherableEntity : MonoBehaviour {
    public GatherableEntityType type;

    [SerializeField]
    private int ItemQuantityMin;
    [SerializeField]
    private int ItemQuantityMax;

    public int GetRandomQuantity() => Random.Range(ItemQuantityMin, ItemQuantityMax);
}


