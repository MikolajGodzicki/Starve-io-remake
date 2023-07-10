using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static Timer timer;

    public static GameManager Instance { get; private set; }

    private void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(this);
        }
        else {
            Instance = this;
        }

        timer = gameObject.GetComponent<Timer>();
        timer.TimerToggle(true);
    }

    public void AddTickAction(Action action) {
        timer.OnTimerTick += action;
    }
}
