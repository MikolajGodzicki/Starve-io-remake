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

    public void Shake() {
        Animator animator = GetComponent<Animator>();
        animator.Play("Shake", 0, 0.0f);
    }
}


