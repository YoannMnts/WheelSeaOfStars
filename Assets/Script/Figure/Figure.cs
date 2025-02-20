using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Figure : MonoBehaviour
{
    private int xpNeedToLevelUp = 6;
    private int currentXp;
    private int maxLevel = 3;
    private int currentLevel = 1;
    private int currentLevelClamp = 1;
    [SerializeField]
    private TextMeshProUGUI currentXpLevelText, currentLevelText;
    
    private void Update()
    {
        if (currentXp >= xpNeedToLevelUp)
        {
            LevelUp();
        }
        currentXpLevelText.text = currentXp.ToString();
        currentLevelText.text = currentLevel.ToString();
    }

    public void GainXp(int xpGained)
    {
        currentXp += xpGained;
    }

    private void LevelUp()
    {
        currentXp = 0;
        currentLevelClamp++;
        currentLevel = Mathf.Clamp(currentLevelClamp , 1, maxLevel);
    }
}