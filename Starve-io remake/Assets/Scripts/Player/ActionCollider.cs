using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionCollider : MonoBehaviour
{
    public PlayerActions Actions;

    private void OnTriggerEnter2D(Collider2D collision) {
        GameObject gameObject = collision.gameObject;
        string collisionTag = gameObject.tag;

        if (collisionTag == "AttackableEntity") {
            Actions.Attack(gameObject);
        }

        if (collisionTag == "GatherableEntity") {
            Actions.Gather(gameObject);
        }
    }
}
