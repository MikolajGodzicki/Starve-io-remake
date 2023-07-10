using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GatherableEntity : MonoBehaviour {
    public GatherableEntityType type;

    [SerializeField]
    private int ItemQuantityMin;
    [SerializeField]
    private int ItemQuantityMax;

    private const int maxDurability = 10;
    public int Durability;

    public int GetRandomQuantity() => Random.Range(ItemQuantityMin, ItemQuantityMax);

    float TimerForNextDurabilityRegen, Cooldown;

    private void Start() {
        Cooldown = 10f;
        TimerForNextDurabilityRegen = Cooldown;

        Durability = maxDurability;
    }

    void Update() {
        if (Durability > 0) {
            return;
        }

        if (TimerForNextDurabilityRegen > 0) {
            TimerForNextDurabilityRegen -= Time.deltaTime;
        }
        else if (TimerForNextDurabilityRegen <= 0) {
            Durability = maxDurability;
            TimerForNextDurabilityRegen = 0;
        }
    }

    public void Shake() {
        Animator animator = GetComponent<Animator>();
        animator.Play("Shake", 0, 0.0f);
    }
}

public enum GatherableEntityType {
    Wood,
    Rock,
    Iron,
    Gold
}