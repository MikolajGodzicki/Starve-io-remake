using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float currentTime;

    public float tickTime;

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
            currentTime += Time.time;
            return;
        }

        OnTimerTick?.Invoke();
        currentTime = 0f;
    }
}
