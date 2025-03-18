
using UnityEngine;

public class Row : MonoBehaviour
{
    public void GiveXp(int ind)
    {
        if (CanXp() == 1 && ind == 0)
        { 
            Debug.Log("je suis Diamond et je donne l'xp");
        }
        else if (CanXp() == 1 && ind == 1)
        { 
            Debug.Log("je suis Square et je donne l'xp");
        }
        
        //int index = (int)symboles;
    }

    private int CanXp()
    {
        return Random.Range(0, 2);
    }
}
