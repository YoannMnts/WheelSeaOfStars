using System;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Wall : MonoBehaviour
{
    private int pvMaxWall = 5;
    private int pvWallTemp;
    private LevelManager levelManager;

    private void Start()
    {
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
    }

    public void BuildWall()
    {
        Player player = levelManager.GetCurrentPlayer();
        pvWallTemp = player.GetCurrentPvWall();
        pvWallTemp++;
        player.SetCurrentPvWall(Mathf.Clamp(pvWallTemp, 1, pvMaxWall));
        player.GetWallPvText().text = player.GetCurrentPvWall().ToString();
    }

    public void DamageWall()
    {
        Player enemie = levelManager.GetEnemie();
        pvWallTemp = enemie.GetCurrentPvWall();
        pvWallTemp--;
        enemie.SetCurrentPvWall(Mathf.Clamp(pvWallTemp, 0, pvMaxWall));
        enemie.GetWallPvText().text = enemie.GetCurrentPvWall().ToString();
    }
}
