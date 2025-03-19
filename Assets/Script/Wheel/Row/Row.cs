
using UnityEngine;

public class Row : MonoBehaviour
{
    [SerializeField] private Player player1, Player2;
    public void GiveXp(int ind)
    {
        if (CanXp() == 1 && ind == 0)
        { 
            player1.GetFigure("L").GainXp(1);
        }
        else if (CanXp() == 1 && ind == 1)
        { 
            player1.GetFigure("R").GainXp(1);
        }
        
        //int index = (int)symboles;
    }

    private int CanXp()
    {
        return Random.Range(0, 2);
    }
}
