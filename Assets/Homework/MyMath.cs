using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

class MyMath : MonoBehaviour
{
    [SerializeField] float number1, number2;
    [SerializeField] float min, max;

    [SerializeField] float number3;
    [SerializeField] float ceiled, floored, rounded;

    [SerializeField] int number4;
    [SerializeField] string sequence;

    void OnValidate()
    {
        min = Min(number1, number2);
        max = Max(number1, number2);

        ceiled = Ceil(number3);
        floored = Floor(number3);
        rounded = Round(number3);

        sequence = ToSequence(number4);
    }

    float Min(float a, float b) 
    {
        if (a > b)
            return b;
        else
            return a;
    }

    float Max(float a, float b) 
    {
        if (a < b)
            return b;
        else
            return a;
    }

    float Floor(float number) 
    {
        // return (int)number;
        float remainder = number % 1;
        return number - remainder;
    }

    float Ceil(float number) 
    {
        float remainder = number % 1;

        if (remainder == 0)
            return number;

        return number - remainder + 1;
    }

    float Round(float number)
    {
        if (number % 1 > 0.5f)
            return Ceil(number);
        else
            return Floor(number);
    }

    bool IsPrime(int number) 
    {
        number = Mathf.Abs(number);

        for (int i = 2; i < number / 2; i++)
        {
            bool isDivisible = number % i == 0;
            if (isDivisible) 
            {
                return false;
            }
        }
        return true;
    }

    string ToSequence(int number) 
    {
        string s = "";
        for (int i = 1; i <= number; i++)
        {
            s = s + i.ToString() + ", ";
        }

        return s;
    }
}