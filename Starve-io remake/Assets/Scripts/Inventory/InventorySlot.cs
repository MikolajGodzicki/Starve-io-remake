using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Item))]
[RequireComponent(typeof(Image))]
public class InventorySlot : MonoBehaviour {
    public int ID;
    public Item _Item;
    public KeyCode SlotInput;
    public Sprite nonActiveSprite;
    public Sprite ActiveSprite;

    public bool IsActive = false;

    public void SetActivity(bool isActive) {
        IsActive = isActive;

        GetComponent<Image>().sprite = IsActive ? ActiveSprite : nonActiveSprite;
    }
}
