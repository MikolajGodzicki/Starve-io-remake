using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public GameObject ActionColliderObj;

    private float currentTime;
    private float attackInterval = 1f;

    void Update() {
        if (Input.GetKeyUp(KeyCode.E) ||
            Input.GetMouseButtonUp(0)) {
            SetCollidingAndAnimation(false);
        }

        if (currentTime < attackInterval) {
            currentTime += Time.time;
            return;
        }

        if (Input.GetKey(KeyCode.E) ||
            Input.GetMouseButton(0)) {
            SetCollidingAndAnimation(true);
        }

        currentTime = 0;
    }

    public void Gather(GameObject gameObject) {
        GatherableEntity gatherableEntity = gameObject.GetComponent<GatherableEntity>();
        //gatherableEntity.Shake();

        GatherableEntityType gatherableEntityType = gatherableEntity.type;
        int itemQuantity = gatherableEntity.GetRandomQuantity();

        Item item = ItemDatabase.Instance.GetItemByGatherType(gatherableEntityType);

        Inventory.Instance.AddItemToInventory(item, itemQuantity);
    }

    public void Attack(GameObject gameObject) {
        Debug.Log($"Attacking {gameObject.name}");
    }

    private void SetCollidingAndAnimation(bool value) {
        ActionColliderObj.SetActive(value);
        PlayerAnimations.Instance.SetPlayerAttack(value);
    }
}
