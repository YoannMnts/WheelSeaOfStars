using System;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private Player currentPlayer, enemie;

    private void Start()
    {
        currentPlayer = GameObject.Find("Player1GO").GetComponent<Player>();
        enemie = GameObject.Find("Player2GO").GetComponent<Player>();
        enemie.GetPlayerCanvas().transform.Find("SpinButton").GetComponent<Button>().enabled = false;
    }

    public void EndTurn()
    {
        Player temp = currentPlayer;
        currentPlayer = enemie;
        enemie = temp;
        currentPlayer.GetPlayerCanvas().transform.Find("SpinButton").GetComponent<Button>().enabled = true;
        enemie.GetPlayerCanvas().transform.Find("SpinButton").GetComponent<Button>().enabled = false;
    }

    public Player GetCurrentPlayer()
    {
        return currentPlayer;
    }

    public Player GetEnemie()
    {
        return enemie;
    }
}