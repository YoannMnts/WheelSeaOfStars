using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Figure figureG, figureD;
    [SerializeField]
    private Wall wall;
    private int pvMax = 10;
    private int currentPv;
    private int currentPvWall;
    [SerializeField]
    private TextMeshProUGUI currentPvText, wallPvText;

    void Start()
    {
        currentPv = pvMax;
    }

    private void Update()
    {
        currentPvText.text = currentPv.ToString();
    }

    public void Attack(Player enemie)
    {
        if (enemie.currentPvWall > 0)
        {
            enemie.GetWall().DamageWall(enemie);
        }
        else
        {
            enemie.currentPv--;
            enemie.currentPv = Mathf.Clamp(enemie.currentPv, 0, pvMax);
            figureG.GainXp(1);
        }
    }

    public int GetCurrentPvWall()
    {
        return currentPvWall;
    }

    public void SetCurrentPvWall(int value)
    {
        currentPvWall = value;
    }

    public TextMeshProUGUI GetWallPvText()
    {
        return wallPvText;
    }

    public Wall GetWall()
    {
        return wall;
    }
}
