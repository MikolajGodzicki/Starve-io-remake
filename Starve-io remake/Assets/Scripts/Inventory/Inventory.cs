using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    private InventorySlot[] InventorySlots;

    [Header("Slots Configuration")]
    [SerializeField]
    private Transform inventoryContainer;
    [SerializeField]
    private GameObject slotPrefab;

    const int minSlotCount = 1;
    const int maxSlotCount = 18;

    private int inventorySlotCount;
    public int InventorySlotCount {
        get { return inventorySlotCount; }
        set {
            if (value < minSlotCount) {
                inventorySlotCount = minSlotCount;
                return;
            }
            if (value > maxSlotCount) {
                inventorySlotCount = maxSlotCount;
                return;
            }

            inventorySlotCount = value;
        }
    }


    private int selectedSlotIndex = 0;
    public int SelectedSlotIndex {
        get { return selectedSlotIndex; }
        set {
            if (value < 0) {
                selectedSlotIndex = 0;
                return;
            }
            if (value > InventorySlotCount - 1) {
                selectedSlotIndex = InventorySlotCount - 1;
                return;
            }

            selectedSlotIndex = value;
        }
    }

    KeyCode[] inventoryKeys;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        }
    }

    private void Start() {
        InitSlotKeys();
        InitSlots();
    }

    private void InitSlotKeys() {
        inventoryKeys = new KeyCode[18] {
            KeyCode.Alpha1,
            KeyCode.Alpha2,
            KeyCode.Alpha3,
            KeyCode.Alpha4,
            KeyCode.Alpha5,
            KeyCode.Alpha6,
            KeyCode.Alpha7,
            KeyCode.Alpha8,
            KeyCode.Alpha9,
            KeyCode.F1,
            KeyCode.F2,
            KeyCode.F3,
            KeyCode.F4,
            KeyCode.F5,
            KeyCode.F6,
            KeyCode.F7,
            KeyCode.F8,
            KeyCode.F9
        };
    }

    private void InitSlots() {
        InventorySlotCount = 9;
        InventorySlots = new InventorySlot[InventorySlotCount];

        for (int i = 0; i < InventorySlotCount; i++) {
            GameObject gameObject = Instantiate(slotPrefab);

            gameObject.transform.SetParent(inventoryContainer);
            //gameObject.transform.parent = inventoryContainer;
            gameObject.name = $"InventorySlot{i}";

            // Inventory slot position step on x vector is 90 
            gameObject.transform.position = new Vector3(45f + 90f * i, -78f, 0);

            InventorySlot slot = gameObject.GetComponent<InventorySlot>();
            slot.SlotInput = inventoryKeys[i];
            slot.ID = i;

            InventorySlots[i] = slot;
        }

        foreach (InventorySlot slot in InventorySlots) {
            slot.GetComponentInChildren<TextMeshProUGUI>().text = slot.SlotInput.ToString().Replace("Alpha", "");
        }

        InventorySlots[SelectedSlotIndex].SetActivity(true);
    }

    public void Update() {
        foreach (InventorySlot slot in InventorySlots) {
            if (Input.GetKey(slot.SlotInput)) {
                InventorySlots[SelectedSlotIndex].SetActivity(false);
                SelectedSlotIndex = slot.ID;
                InventorySlots[SelectedSlotIndex].SetActivity(true);
            }
        }
    }

    public void AddItemToInventory(Item item, int itemQuantity) {
        foreach (InventorySlot slot in InventorySlots) {
            if (slot.IsEmpty) {
                slot.Item = item.Copy();
                slot.Item.Quantity = itemQuantity;
                slot.IsEmpty = false;

                slot.UpdateSlot();
                break;
            }

            if (slot.Item.ID == item.ID) {
                slot.Item.Quantity += itemQuantity;

                slot.UpdateSlot();
                break;
            }
        }
    }
}
