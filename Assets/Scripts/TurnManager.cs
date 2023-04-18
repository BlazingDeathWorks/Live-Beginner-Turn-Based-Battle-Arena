using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public static TurnManager Instance;
    [SerializeField] private GameObject actionMenu;
    private bool playerTurn = false;

    private void Awake()
    {
        Instance = this;
    }

    private IEnumerator NextTurn()
    {
        if (!playerTurn)
        {
            actionMenu.SetActive(false);
            yield return new WaitForSecondsRealtime(1f);
            GameManager.Instance.GetCurrentEnemy().DamagePlayer();
        }
        else
        {
            yield return new WaitForSecondsRealtime(1f);
            actionMenu.SetActive(true);
        }
    }

    public void EndTurn()
    {
        playerTurn = !playerTurn;
        StartCoroutine(NextTurn());
    }
}
