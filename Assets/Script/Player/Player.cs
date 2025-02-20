using System;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Figure figure;
    [SerializeField]
    private Wall wall;
    private int pvMax = 10;
    private int currentPv;
    private int currentPvWall;
    [SerializeField]
    private TextMeshProUGUI currentPvText;

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
            wall.DamageWall();
        }
        else
        {
            enemie.currentPv--;
            enemie.currentPv = Mathf.Clamp(enemie.currentPv, 0, pvMax);
            figure.GainXp(1);
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
}
