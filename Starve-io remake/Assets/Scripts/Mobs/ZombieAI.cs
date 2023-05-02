using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    private float radius = 5f;
    private float speed = 4f;

    void Update()
    {
        Follow();
    }

    private void Follow() {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(this.transform.position, radius);

        foreach (Collider2D collider in colliders) {
            if (collider.name == "Player") {
                Vector3 playerPos = collider.transform.position;
                transform.position = Vector2.MoveTowards(transform.position, collider.transform.position, speed * Time.deltaTime);

                Rotate(playerPos);
            }
        }
    }

    private void Rotate(Vector3 targetPos) {
        Vector2 position = new Vector2(targetPos.x - transform.position.x, targetPos.y - transform.position.y);

        transform.up = position;
    }
}
