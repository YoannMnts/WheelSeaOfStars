using System;
using UnityEngine;

public class Builder : Figure
{
    private int pointNeedToAtkMax = 6;

    public void FixedUpdate()
    {
        if (pointNeedToAtk >= pointNeedToAtkMax)
        {
            pointNeedToAtk = 0;
            Debug.Log("je suis builder et je build");
        }
    }
}
