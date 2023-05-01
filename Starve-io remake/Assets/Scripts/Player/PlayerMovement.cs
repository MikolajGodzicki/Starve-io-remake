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
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(inputH, inputV, 0f) * speed * Time.deltaTime;

        transform.position += movement;

        if (inputH != 0 || inputV != 0) {
            playerAnimations.SetPlayerRun(true);
        }
        else {
            playerAnimations.SetPlayerRun(false);
        }
    }

    private void Rotate() {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 position = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);

        transform.up = position;
    }
}
