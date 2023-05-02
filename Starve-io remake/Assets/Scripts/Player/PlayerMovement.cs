using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;

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
            PlayerAnimations.Instance.SetPlayerRun(true);
        }
        else {
            PlayerAnimations.Instance.SetPlayerRun(false);
        }
    }

    private void Rotate() {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 position = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);

        transform.up = position;
    }
}
