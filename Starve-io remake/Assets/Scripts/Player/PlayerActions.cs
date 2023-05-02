using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    void Update() {
        if (Input.GetKeyDown(KeyCode.E)) 
            Gather();

        if (Input.GetMouseButtonDown(0) ||
            Input.GetKeyDown(KeyCode.F)) 
            Attack();
    }

    private void Gather() {
        Debug.Log("Gathering");
    }

    private void Attack() {
        Debug.Log("Attacking");
    }
}
