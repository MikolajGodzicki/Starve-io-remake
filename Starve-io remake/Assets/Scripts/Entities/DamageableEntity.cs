using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DamageableEntity : MonoBehaviour, IDamageable
{
    public const int maxHealth = 100;
    public int health;

    [SerializeField]
    private Image healthBar;

    private void Start() {
        health = maxHealth;
        UpdateHealthBar();
    }

    public void UpdateHealthBar() {
        if (healthBar !=  null) {
            healthBar.fillAmount = (float)health / maxHealth;
        }
    }

    public void DealDamage(int amount) {
        health -= amount;

        if (health <= 0) {
            Die();
            return;
        }

        UpdateHealthBar();
    }

    public void Die() {
        Destroy(gameObject);
    }
}
