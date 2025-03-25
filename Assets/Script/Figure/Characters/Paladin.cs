using UnityEngine;

public class Paladin : Figure
{
    private int pointNeedToAtkMax = 7;

    public void FixedUpdate()
    {
        if (pointNeedToAtk >= pointNeedToAtkMax)
        {
            pointNeedToAtk = 0;
            Debug.Log("je suis Paladin et je pala le din");
        }
    }
}
