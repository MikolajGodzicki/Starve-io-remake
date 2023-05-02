using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public static PlayerAnimations Instance;

    [SerializeField]
    private Animator animator;

    public void Awake() {
        if (Instance == null) {
            Instance = this;
        }
    }

    public void SetPlayerRun(bool value) {
        animator.SetBool("IsRunning", value);
    }

    public void SetPlayerAttack(bool value) {
        animator.SetBool("IsAttacking", value);
    }
}
