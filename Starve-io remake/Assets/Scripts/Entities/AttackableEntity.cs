using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AttackableEntity : MonoBehaviour
{
    public IEnumerable<GameObject> GetCollidedGameObjects() {
        Collider2D childCollider = transform.GetChild(0).gameObject.GetComponent<Collider2D>();

        List<Collider2D> colliders = new List<Collider2D>();
        childCollider.OverlapCollider(new ContactFilter2D().NoFilter(), colliders);

        return colliders.Select(e => e.gameObject);
    }

    public void Attack(IEnumerable<GameObject> gameObjects, int damage) {
        foreach (GameObject gameObject in gameObjects) {
            IDamageable obj = gameObject.GetComponent<IDamageable>();
            obj.DealDamage(damage);
        }
    }

    public void PlayAttackAnimation() {
        GetComponent<InteractableAnimationEntity>().PlayAttackAnimationOnce();
    }
}
