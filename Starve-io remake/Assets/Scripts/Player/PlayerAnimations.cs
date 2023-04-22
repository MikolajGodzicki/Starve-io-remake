using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator animator;

    private void Start() {
        animator = GetComponent<Animator>();
    }

    public void SetPlayerRun(bool value) {
        animator.SetBool("IsRunning", value);
    }   
}
