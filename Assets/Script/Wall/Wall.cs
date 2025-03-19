using System;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Wall : MonoBehaviour
{
    private int pvMaxWall = 5;
    private int pvWallTemp;
    
    public void BuildWall(Player player)
    {
        pvWallTemp = player.GetCurrentPvWall();
        pvWallTemp++;
        player.SetCurrentPvWall(Mathf.Clamp(pvWallTemp, 1, pvMaxWall));
        player.GetWallPvText().text = player.GetCurrentPvWall().ToString();
    }

    public void DamageWall(Player player)
    {
        pvWallTemp = player.GetCurrentPvWall();
        pvWallTemp--;
        player.SetCurrentPvWall(Mathf.Clamp(pvWallTemp, 0, pvMaxWall));
        player.GetWallPvText().text = player.GetCurrentPvWall().ToString();
    }
}
