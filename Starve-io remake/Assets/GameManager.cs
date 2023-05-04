using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int TickTime;

    static Timer timer;

    private void Start() {
        timer = gameObject.AddComponent<Timer>();
        timer.tickTime = TickTime;
        timer.TimerToggle(true);
    }

    public static void AddTickAction(Action action) {
        timer.OnTimerTick += action;
    }
}
