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

    public void PlayActionAnimationOnce() {
        animator.Play("action");
    }

    public void PlayDamagedAnimationOnce() {
        animator.Play("damaged");
    }
}
