using System;
using UnityEngine;

public class Assassin : Figure
{
    private int pointNeedToAtkMax = 7;

    public void FixedUpdate()
    {
        if (pointNeedToAtk >= pointNeedToAtkMax)
        {
            pointNeedToAtk = 0;
            Debug.Log("je suis Assassin et j'assassine");
        }
    }
}
