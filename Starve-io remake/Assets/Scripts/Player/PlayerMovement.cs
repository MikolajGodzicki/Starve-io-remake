using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerAnimations playerAnimations;
    private Rigidbody2D rb;

    private Vector2 movement;

    public float speed = 5;

    private void Start() {
        playerAnimations = GetComponent<PlayerAnimations>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        Move();
        Rotate();
    }

    private void Move() {
        float inputH = Input.GetAxisRaw("Horizontal");
        float inputV = Input.GetAxisRaw("Vertical");

        movement = new Vector2(inputH, inputV).normalized;

        /*
        if (inputH != 0 || inputV != 0) {
            playerAnimations.SetPlayerRun(true);
        } else {
            playerAnimations.SetPlayerRun(false);
        }
        */
    }

    private void FixedUpdate() {
        //rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        rb.velocity = new Vector2(movement.x * speed, movement.y * speed);
    }

    private void Rotate() {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 position = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);

        transform.up = position;
    }
}
