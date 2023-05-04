using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Mob : MonoBehaviour
{
    private const int maxHealth = 100;
    private int health;

    [SerializeField]
    private Image healthBar;

    private void Start() {
        health = maxHealth;
        UpdateHealthBar();
    }

    public void UpdateHealthBar() {
        if (health <= 0) {
            Die();
            return;
        }

        healthBar.fillAmount = (float) health / maxHealth; 
    }

    public void DealDamage(int amount) {
        health -= amount;
        UpdateHealthBar();
    }

    public void Die() {
        Destroy(gameObject);
    }
}
