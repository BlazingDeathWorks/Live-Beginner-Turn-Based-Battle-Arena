using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameObject gameOverOverlay;
    [SerializeField] private Slider playerHealthSlider;
    private int health;

    private void Awake()
    {
        health = (int)playerHealthSlider.maxValue;
    }

    private void UpdateHealthSlider()
    {
        playerHealthSlider.value = health;
    }

    private void CheckHealth()
    {
        if (health <= 0)
        {
            gameOverOverlay.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void AddHealth(int value)
    {
        health += value;
        health = (int)Mathf.Clamp(health, 0, playerHealthSlider.maxValue);
        UpdateHealthSlider();
    }

    public void Damage(int value)
    {
        health -= value;
        UpdateHealthSlider();
        CheckHealth();
    }
}
