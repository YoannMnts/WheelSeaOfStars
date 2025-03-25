using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Random = UnityEngine.Random;

public class Wheel : MonoBehaviour
{
    [SerializeField] private Row row;
    [SerializeField] private int[] rowTab;
    private int spinNumber;
    private LevelManager levelManager;
    private Wall wall;
    [SerializeField] private bool[] lockTab;
    [SerializeField] private int[] wheelTab;

    private void Start()
    {
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        wall = GameObject.Find("WallManager").GetComponent<Wall>();
    }

    public void Spin()
    {
        GameObject.Find("EndTurnButton").GetComponent<Button>().interactable = true;
        for (int i = 0; i < 5; i++)
        {
            int curentSymboles = Random.Range(0, 4);
            if (lockTab[i] == false)
            {
                rowTab[i] = curentSymboles;
                row.rowGoTab[i].GetComponentInChildren<TextMeshProUGUI>().text = curentSymboles.ToString();
            }
            if (curentSymboles == 0 || curentSymboles == 1)
                row.GiveXp(curentSymboles, levelManager.GetCurrentPlayer());
        }
        spinNumber++;
        levelManager.CanIEndTurn();
    }

    public int GetSpinNumber()
    {
        return spinNumber;
    }

    public void SetSpinNumber(int value)
    {
        spinNumber = value;
    }

    public void MakeWheelTab()
    {
        for (int i = 0; i < rowTab.Length; i++)
        {
            wheelTab[rowTab[i]]++;
        }
    }
    public int[] GetWheelTab()
    {
        return wheelTab;
    }

    public void ResetWheelTab()
    {
        for (int i = 0; i < wheelTab.Length; i++)
        {
            wheelTab[i] = 0;
        }
    }

    public void ResetLockTab()
    {
        for (int i = 0; i < lockTab.Length; i++)
        {
            lockTab[i] = false;
        }
    }

    public void ResetRowTab()
    {
        for (int i = 0; i < rowTab.Length; i++)
        {
            rowTab[i] = 3;
        }
    }

    public void LockRow(int index)
    {
        lockTab[index] = !lockTab[index];
    }
}