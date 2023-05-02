using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int TickTime;

    Timer timer;

    private void Start() {
        timer = gameObject.AddComponent<Timer>();
    }

    public void AddTickAction(Action action) {
        timer.TimerTick += action;
    }
}
