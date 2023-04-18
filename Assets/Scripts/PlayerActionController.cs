using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionController : MonoBehaviour
{
    private int pow = 1;
    private PlayerHealth playerHealth;

    private void Awake()
    {
        playerHealth = GetComponent<PlayerHealth>();
    }

    public void Attack()
    {
        GameManager.Instance.GetCurrentEnemy().DamageEnemy(pow);
    }

    public void Heal()
    {
        playerHealth.AddHealth(pow);
    }

    public void Boost()
    {
        pow++;
    }
}
