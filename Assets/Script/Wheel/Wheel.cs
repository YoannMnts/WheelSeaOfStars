using UnityEngine;

public class Wheel : MonoBehaviour
{
    [SerializeField] private Row row;
    [SerializeField] private int[] rowTab;
    
    public void Spin()
    {
        for (int i = 0; i < 5; i++)
        {
            int curentSymboles = Random.Range(0, 4);
            rowTab[i] = curentSymboles;
            if (curentSymboles == 0 || curentSymboles == 1)
                row.GiveXp(curentSymboles);
        }
    }
}
