using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner Instance;
    [SerializeField] private Enemy enemyPrefab;
    [SerializeField] private Slider enemyHealthBar;
    [SerializeField] private int minHealth, maxHealth, minDamage, maxDamage;

    private void Awake()
    {
        Instance = this;
        SpawnEnemy();
    }

    private IEnumerator SpawnEnemyAfterTime(float waitTime)
    {
        yield return new WaitForSecondsRealtime(waitTime);
        Enemy enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        enemy.SetEnemy(enemyHealthBar, Random.Range(minHealth, maxHealth + 1), Random.Range(minDamage, maxDamage + 1));
        GameManager.Instance.RegisterEnemy(enemy);
        TurnManager.Instance.EndTurn();
    }

    public void SpawnEnemy(float waitTime = 0)
    {
        StartCoroutine(SpawnEnemyAfterTime(waitTime));
    }
}
