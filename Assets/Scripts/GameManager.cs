using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private PlayerHealth player;
    private Enemy currentEnemy;

    private void Awake()
    {
        Instance = this;
        Time.timeScale = 1;
    }

    public PlayerHealth GetPlayer()
    {
        return player;
    }

    public Enemy GetCurrentEnemy()
    {
        return currentEnemy;
    }

    public void RegisterEnemy(Enemy enemy)
    {
        currentEnemy = enemy;
    }
}
