using UnityEngine;

public class Power : MonoBehaviour
{
    [SerializeField] int baseNumber = 10;
    [SerializeField] int exponent = 3;

    void Start()
    {
        int accum = 1;
        for (int i = 0; i < exponent; i++)
        {
            accum = accum * baseNumber;
        }
        Debug.Log(accum);
    }
}