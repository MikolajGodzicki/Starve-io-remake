using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movementSpeed;

    private void Start() {
         movementSpeed = 7.5f;
    }

    private void Update() {
        Move();
        Rotate();
    }

    private void Move() {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(inputHorizontal, inputVertical, 0f) * movementSpeed * Time.deltaTime;

        transform.position += movement;

        if (inputHorizontal != 0 || inputVertical != 0) {
            GetComponent<InteractableAnimationEntity>().SetRun(true);
        }
        else {
            GetComponent<InteractableAnimationEntity>().SetRun(false);
        }
    }

    private void Rotate() {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 finalPosition = new Vector2(mousePos.x - transform.position.x,  
                                            mousePos.y - transform.position.y);

        transform.up = finalPosition;
    }
}
