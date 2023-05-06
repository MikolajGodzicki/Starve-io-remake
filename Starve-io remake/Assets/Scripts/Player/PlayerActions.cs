using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerActions : AttackableEntity {
    float TimerForNextAttack, Cooldown;

    private void Start() {
        Cooldown = 0.4f;
        TimerForNextAttack = Cooldown;
    }

    void Update() {
        if (TimerForNextAttack > 0) {
            TimerForNextAttack -= Time.deltaTime;
        } else if (TimerForNextAttack <= 0) {
            if (Input.GetMouseButtonDown(0)) {
                PlayAttackAnimation();

                IEnumerable<GameObject> gameObjects = GetCollidedGameObjects();
                Attack(gameObjects.Where(e => e.gameObject.tag == "AttackableEntity"), 15);
                gameObjects.Where(e => e.gameObject.tag == "AttackableEntity")
                                    .ToList()
                                    .ForEach(e => e.gameObject
                                                   .GetComponent<AttackableEntity>()
                                                   .PlayDamagedAnimation());
                Gather(gameObjects.Where(e => e.gameObject.tag == "GatherableEntity"));

                TimerForNextAttack = Cooldown;
            }
        }   
    }

    public void Gather(IEnumerable<GameObject> gameObjects) {
        foreach (GameObject gameObject in gameObjects) {
            GatherableEntity gatherableEntity = gameObject.GetComponent<GatherableEntity>();
            gatherableEntity.Shake();

            GatherableEntityType gatherableEntityType = gatherableEntity.type;
            int itemQuantity = gatherableEntity.GetRandomQuantity();

            Item item = ItemDatabase.Instance.GetItemByGatherType(gatherableEntityType);

            Inventory.Instance.AddItemToInventory(item, itemQuantity);
        }
    }
}
