using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class ZombieAI : AttackableEntity {
    private float followRadius = 5f;
    private float speed = 4f;

    float TimerForNextAttack, Cooldown;

    private void Start() {
        Cooldown = 1;
        TimerForNextAttack = Cooldown;
    }

    void Update() {
        Follow();
    }

    private void Follow() {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(this.transform.position, followRadius);
        Move(colliders.FirstOrDefault(e => e.name == "Player"));


        if (TimerForNextAttack > 0) {
            TimerForNextAttack -= Time.deltaTime;
        }
        else if (TimerForNextAttack <= 0) {
            IEnumerable<GameObject> gameObjects = GetCollidedGameObjects();
            if (gameObjects.Where(e => e.gameObject.tag == "Player").ToArray().Length > 0) {
                Attack(gameObjects.Where(e => e.gameObject.tag == "Player"), 15);
                PlayAttackAnimation();
            }

            TimerForNextAttack = Cooldown;
        }
    }

    private void Move(Collider2D collider) {
        if (collider == null) return;

        Vector3 playerPos = collider.transform.position;
        transform.position = Vector2.MoveTowards(transform.position, collider.transform.position, speed * Time.deltaTime);

        Rotate(playerPos);
    }

    private void Rotate(Vector3 targetPos) {
        Vector2 position = new Vector2(targetPos.x - transform.position.x, targetPos.y - transform.position.y);

        transform.up = position;
    }
}
