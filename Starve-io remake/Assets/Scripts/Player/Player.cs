using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : DamageableEntity
{
    public const int maxStarve = 100;
    public int starve;
    [SerializeField]
    private Image starveBar;

    public const int maxThirst = 100;
    public int thirst;
    [SerializeField]
    private Image thirstBar;

    public const int maxTemperature = 50;
    public int temperature;
    [SerializeField]
    private Image temperatureBar;

    public void Start() {
        GameManager.Instance.AddTickAction(Starve);

        health = maxHealth;
        starve = maxStarve;
        thirst = maxThirst;
        temperature = maxTemperature;
    }

    public void UpdateBars() {
        if (starveBar != null) {
            starveBar.fillAmount = (float)starve / maxStarve;
        }

        if (thirstBar != null) {
            thirstBar.fillAmount = (float)thirst / maxThirst;
        }

        if (temperatureBar != null) {
            temperatureBar.fillAmount = (float)temperature / maxTemperature;
        }
    }

    public void Update() {
        UpdateBars();
    }

    private void Starve() {
        starve--;
    }
}
