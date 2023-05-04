using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAnimations : MonoBehaviour
{
    public static ZombieAnimations Instance;

    [SerializeField]
    private Animator animator;

    public void Awake() {
        if (Instance == null) {
            Instance = this;
        }
    }

    public void SetZombieRun(bool value) {
        animator.SetBool("IsRunning", value);
    }

    public void SetZombieAttack(bool value) {
        animator.SetBool("IsAttacking", value);
    }
}
