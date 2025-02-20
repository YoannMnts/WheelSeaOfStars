using System;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Wall : MonoBehaviour
{
    private int pvMaxWall = 5;
    private Player player;
    private int currentPvWallClamp = 1;
    private TextMeshProUGUI wallTextMesh;
    

    public void SetClamp()
    {
        currentPvWallClamp = player.GetCurrentPvWall();
    }

    public void UpdateText(TextMeshProUGUI pvWallText)
    {
        pvWallText.text = player.GetCurrentPvWall().ToString();
        wallTextMesh = pvWallText;
    }

    public void BuildWall()
    {
        currentPvWallClamp++;
        player.SetCurrentPvWall(Mathf.Clamp(currentPvWallClamp, 1, pvMaxWall));
        UpdateText(wallTextMesh);
    }

    public void DamageWall()
    {
        currentPvWallClamp--;
        player.SetCurrentPvWall(Mathf.Clamp(currentPvWallClamp, 0, pvMaxWall));
        UpdateText(wallTextMesh);
    }

    public void SetPlayer(Player player)
    {
        this.player = player;
    }
}
