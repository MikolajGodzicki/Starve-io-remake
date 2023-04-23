using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public float DampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform Target;

    void Update() {
        if (Target) {
            Vector3 point = Camera.main.WorldToViewportPoint(Target.position);
            Vector3 delta = Target.position - Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, DampTime);
        }
    }
}