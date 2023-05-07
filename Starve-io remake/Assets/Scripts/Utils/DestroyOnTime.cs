using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTime : MonoBehaviour
{
    public float DestroyTime = 2f;

    private void Start() {
        Destroy(gameObject, DestroyTime);
    }
}
