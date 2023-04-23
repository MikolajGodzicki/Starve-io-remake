using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private InventorySlot[] InventorySlots;

    [SerializeField]
    private Transform inventoryContainer;

    [SerializeField]
    private int selectedSlotIndex = 0;

    private void Start() {
        foreach (InventorySlot slot in GetSlots()) {
            slot.GetComponentInChildren<TextMeshProUGUI>().text = slot.ID.ToString();
        }
    }

    public void Update() {
        foreach (InventorySlot slot in InventorySlots) {
            if (Input.GetKey(slot.SlotInput)) {
                InventorySlots[selectedSlotIndex].SetActivity(false);
                selectedSlotIndex = slot.ID - 1;
                InventorySlots[selectedSlotIndex].SetActivity(true);
            }
        }
    }

    private IEnumerable<InventorySlot> GetSlots() {
        int childCount = inventoryContainer.childCount;
        InventorySlots = new InventorySlot[childCount];
        for (int i = 0; i < childCount; i++) {
            Transform child = inventoryContainer.GetChild(i);
            InventorySlot inventorySlot = child.GetComponent<InventorySlot>();
            InventorySlots[i] = inventorySlot;
            yield return inventorySlot;
        }
    }
}
