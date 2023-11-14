using UnityEngine;

class MyMath : MonoBehaviour
{
    [SerializeField] float number1, number2;
    [SerializeField] float min, max;

    [SerializeField] float number3;
    [SerializeField] float ceiled, floored, rounded;

    [SerializeField] int number4;
    [SerializeField] string sequence;

    void Start()
    {
        // PrintPrimes(100);

        int x = LeastCommonMultiple(4, 5);
        Debug.Log(x);

        Vector2 v1 = new Vector2(2, 3);
        Vector2 v2 = new Vector2(4, 11);

        float d = Vector2.Distance(v1, v2);

    }


    bool IsPrime(int number)
    {
        number = Mathf.Abs(number);

        for (int i = 2; i <= number / 2; i++)
        {
            bool isDivisible = number % i == 0;
            if (isDivisible)
            {
                return false;
            }
        }
        return true;
    }

    void PrintPrimes(int n)
    {
        int primesFound = 0;
        for (int i = 2; primesFound < n; i++)
        {
            bool isPrime = IsPrime(i);
            if (isPrime)
            {
                Debug.Log(i);
                primesFound++;
            }
        }
    }






    int LeastCommonMultiple(int a, int b) 
    {
        int max = Mathf.Max(a, b);

        for (int i = max; i < int.MaxValue ; i++)
        {
            bool d1 = i % a == 0;
            bool d2 = i % b == 0;

            if (d1 && d2)
                return i;
        }

        return -1;
    }











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

    string ToSequence(int number) 
    {
        string s = "";
        for (int i = 1; i <= number; i++)
        {
            s = s + i.ToString() + ", ";
        }

        return s;
    }

    float Distance(Vector2 a, Vector2 b) 
    { 
        return (a - b).magnitude;
    }



}