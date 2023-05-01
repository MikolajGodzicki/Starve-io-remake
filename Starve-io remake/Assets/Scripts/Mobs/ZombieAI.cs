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
        Collider2D[] colliders = Physics2D.OverlapCircleAll(this.transform.position, radius);

        foreach (Collider2D collider in colliders) {
            if (collider.name == "Player") {
                transform.position = Vector2.MoveTowards(transform.position, collider.transform.position, speed * Time.deltaTime);
            }
        }
    }
}
