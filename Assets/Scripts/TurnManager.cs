using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public static TurnManager Instance;
    [SerializeField] private GameObject actionMenu;
    private bool playerTurn = true;

    private void Awake()
    {
        Instance = this;
    }

    private IEnumerator NextTurn(bool reset = false)
    {
        if (reset)
        {
            playerTurn = true;
            yield return new WaitForSecondsRealtime(1f);
            actionMenu.SetActive(true);
            yield break;
        }

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

    public void EndTurn(bool reset = false)
    {
        playerTurn = !playerTurn;
        StartCoroutine(NextTurn(reset));
    }
}
