using UnityEngine;

public class DarkWizard : Figure
{
    private int pointNeedToAtkMax = 7;

    public void FixedUpdate()
    {
        if (pointNeedToAtk >= pointNeedToAtkMax)
        {
            pointNeedToAtk = 0;
            Debug.Log("je suis DarkWizard et je wizard le dark");
        }
    }
}
