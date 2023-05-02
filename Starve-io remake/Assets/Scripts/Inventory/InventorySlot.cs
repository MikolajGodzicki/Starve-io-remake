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

    public KeyCode SlotInput;

    public Sprite nonActiveSprite;
    public Sprite ActiveSprite;

    public Image ItemImage;
    public TextMeshProUGUI ItemQuantityText;

    public bool IsActive = false;
    public bool IsEmpty = true;

    private void Start() {
        UpdateSlot();
    }

    public void SetActivity(bool isActive) {
        IsActive = isActive;

        GetComponent<Image>().sprite = IsActive ? ActiveSprite : nonActiveSprite;
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
