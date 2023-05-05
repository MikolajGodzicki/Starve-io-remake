using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class InteractableAnimationEntity: MonoBehaviour
{
    private Animator animator;

    public void Awake() {
        animator = GetComponent<Animator>();
    }

    public void SetRun(bool value) {
        animator.SetBool("IsRunning", value);
    }

    public void SetAttack(bool value) {
        animator.SetBool("IsAttacking", value);
    }

    public void PlayAttackAnimationOnce() {
        animator.Play("attack", -1, 0f);
    }
}
