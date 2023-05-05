using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Item))]
[RequireComponent(typeof(Image))]
public class InventorySlot : MonoBehaviour {
    public int ID;
    public Item Item;

    public KeyCode slotInput;

    public Sprite unselectedSlotSprite;
    public Sprite selectedSlotSprite;

    public Image ItemImage;
    public TextMeshProUGUI ItemQuantityText;

    public bool isActive = false;
    public bool isEmpty = true;

    private void Start() {
        UpdateSlot();
    }

    public void SetActivity(bool isActive) {
        this.isActive = isActive;

        GetComponent<Image>().sprite = this.isActive ? selectedSlotSprite : unselectedSlotSprite;
    }

    public void UpdateSlot() {
        if (Item == null) {
            ItemImage.sprite = null;
            ItemImage.color = Color.clear;
            ItemQuantityText.text = "";

            return;
        }

        ItemImage.sprite = Item.Sprite;
        ItemImage.color = Color.white;
        ItemQuantityText.text = Item.Quantity.ToString();
    }
}
