using UnityEngine;

class MyMath : MonoBehaviour
{
	[SerializeField] int number;
	[SerializeField] int sumOfDigits;

	void OnValidate()
    {
        sumOfDigits = SumOfDigits(number);
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












    int SumOfDigits(int number)
    {
        int result = 0;

        while (number != 0)
        {
            int lastDigit = number % 10;
            result += lastDigit;
            number /= 10;
		}

        return result;
    }


    bool IsPythagorean(int a, int b, int c)
    {
        return (a * a) + (b * b) == (c * c);
    }












}