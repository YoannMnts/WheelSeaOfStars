
using UnityEngine;

public class Row : MonoBehaviour
{
    public GameObject[] rowGoTab;
    public void GiveXp(int ind, Player player)
    {
        if (CanXp() == 1 && ind == 0)
        { 
            //player.GetFigure("L").GainXp(1);
        }
        else if (CanXp() == 1 && ind == 1)
        { 
            //player.GetFigure("R").GainXp(1);
        }
        
        //int index = (int)symboles;
    }

    private int CanXp()
    {
        return Random.Range(0, 2);
    }
}