using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    [SerializeField] private Figure figureL, figureR;
    private Wall wall;
    private int pvMax = 10;
    private int currentPv;
    private int currentPvWall;
    [SerializeField] private GameObject playerCanvas;
    private TextMeshProUGUI currentPvText, wallPvText;
    private LevelManager levelManager;

    void Start()
    {
        currentPvText = playerCanvas.transform.Find("PlayerHp").GetComponent<TextMeshProUGUI>();
        wallPvText = playerCanvas.transform.Find("Wall").GetComponent<TextMeshProUGUI>();
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        wall = GameObject.Find("WallManager").GetComponent<Wall>();
        currentPv = pvMax;
    }

    private void Update()
    {
        currentPvText.text = currentPv.ToString();
    }

    public void Attack(Figure currentFigure)
    {
        Player enemie = levelManager.GetEnemie();
        currentFigure.pointNeedToAtk++;
        if (enemie.currentPvWall > 0)
        {
            wall.DamageWall();
        }
        else
        {
            enemie.currentPv--;
            enemie.currentPv = Mathf.Clamp(enemie.currentPv, 0, pvMax);
            currentFigure.GainXp(1);
        }
    }

    public GameObject GetPlayerCanvas()
    {
        return playerCanvas;
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

    public Figure GetFigure(String LorR)
    {
        if (LorR == "L")
        {
            return figureL;
        }
        else
        {
            return figureR;
        }
    }
}
