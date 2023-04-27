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

    public void SetActivity(bool isActive) {
        IsActive = isActive;

        GetComponent<Image>().sprite = IsActive ? ActiveSprite : nonActiveSprite;
    }

    public void UpdateSlot() {
        ItemImage.sprite = Item.Sprite;
        ItemQuantityText.text = Item.Quantity.ToString();
    }
}
