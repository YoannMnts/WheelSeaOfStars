using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Wheel : MonoBehaviour
{
    [SerializeField] private Row row;
    [SerializeField] private int[] rowTab;
    private int spinNumber;
    private LevelManager levelManager;
    private Wall wall;

    private void Start()
    {
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        wall = GameObject.Find("WallManager").GetComponent<Wall>();
    }

    void CanIEndTurn()
    {
        if (spinNumber >= 3)
        {
            levelManager.EndTurn();
            spinNumber = 0;
        }
    }

    public void Spin()
    {
        for (int i = 0; i < 5; i++)
        {
            int curentSymboles = Random.Range(0, 4);
            rowTab[i] = curentSymboles;
            if (curentSymboles == 0 || curentSymboles == 1)
                row.GiveXp(curentSymboles, levelManager.GetCurrentPlayer());
            else if (curentSymboles == 2)
                wall.BuildWall();
        }
        spinNumber++;
        CanIEndTurn();
    }
}