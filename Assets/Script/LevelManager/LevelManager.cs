using System;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private Player currentPlayer, enemie;
    private Wheel currentWheel;
    private Wall currentWall;
    

    private void Start()
    {
        currentPlayer = GameObject.Find("Player1GO").GetComponent<Player>();
        enemie = GameObject.Find("Player2GO").GetComponent<Player>();
        enemie.GetPlayerCanvas().transform.Find("SpinButton").GetComponent<Button>().interactable = false;
        currentWheel = GameObject.Find("WheelManager").GetComponent<Wheel>();
        currentWall = GameObject.Find("WallManager").GetComponent<Wall>();
    }

    public void EndTurn()
    {
        Player temp = currentPlayer;
        currentWheel.MakeWheelTab();
        for (int i = 0; i < currentWheel.GetWheelTab().Length; i++)
        {
            if (currentWheel.GetWheelTab()[i] >= 3)
            {
                for (int j = 0; j < currentWheel.GetWheelTab()[i] - 2; j++)
                {
                    if (i == 0)
                        currentPlayer.Attack(currentPlayer.GetFigure("L"));
                    else if (i == 1)
                        currentPlayer.Attack(currentPlayer.GetFigure("R"));
                    else if (i == 2)
                        currentWall.BuildWall();
                }
            }
        }
        currentWheel.ResetWheelTab();
        currentWheel.ResetLockTab();
        currentWheel.ResetRowTab();
        currentPlayer = enemie;
        enemie = temp;
        currentPlayer.GetPlayerCanvas().transform.Find("SpinButton").GetComponent<Button>().interactable = true;
        enemie.GetPlayerCanvas().transform.Find("SpinButton").GetComponent<Button>().interactable = false;
    }

    public Player GetCurrentPlayer()
    {
        return currentPlayer;
    }

    public Player GetEnemie()
    {
        return enemie;
    }
    
    public void CanIEndTurn()
    {
        if (currentWheel.GetSpinNumber() >= 3)
        {
            EndTurn();
            currentWheel.SetSpinNumber(0);
        }
    }
}