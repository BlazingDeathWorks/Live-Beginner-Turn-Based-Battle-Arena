using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private int health;
    private int damage;
    private Slider healthBar;

    private void Start()
    {
        healthBar.maxValue = health;
        healthBar.value = health;
    }

    public void DamagePlayer()
    {
        GameManager.Instance.GetPlayer().Damage(damage);
        TurnManager.Instance.EndTurn();
    }

    public void DamageEnemy(int damage)
    {
        health -= damage;
        healthBar.value = health;
        if (health <= 0)
        {
            Destroy(gameObject);
            ScoreManager.Instance.ScoreIncrease();
            TurnManager.Instance.EndTurn();
            EnemySpawner.Instance.SpawnEnemy(0.5f);
        }
    }

    public void SetEnemy(Slider slider, int health, int damage)
    {
        healthBar = slider;
        this.health = health;
        this.damage = damage;
    }
}
