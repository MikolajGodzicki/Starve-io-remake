using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float currentTime = 0f;

    public float tickTime = 5f;

    private bool isRunning = false;

    public Action OnTimerTick;

    public void TimerToggle(bool value) {
        isRunning = value;
    }

    void Update()
    {
        if (!isRunning) {
            return;
        }

        if (currentTime < tickTime) {
            currentTime += Time.deltaTime;
            return;
        }

        Debug.Log(currentTime);

        OnTimerTick?.Invoke();
        currentTime = 0f;
    }
}
