using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public float DampTime = 0.15f;

    private Vector3 velocity = Vector3.zero;

    public Transform targetTransform;

    void Update() {
        if (targetTransform) {
            Vector3 viewportPoint = Camera.main.WorldToViewportPoint(targetTransform.position);

            Vector3 deltaPosition = targetTransform.position - Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, viewportPoint.z));

            Vector3 destination = transform.position + deltaPosition;

            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, DampTime);
        }
    }
}