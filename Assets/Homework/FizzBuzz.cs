using UnityEngine;

class FizzBuzz : MonoBehaviour
{
    [SerializeField] int number = 10;

    void Start()
    {
        for (int i = 1; i <= number; i++)
        {
            bool fizz = i % 3 == 0;
            bool buzz = i % 5 == 0;

            if (fizz && buzz)
            {
                Debug.Log("FIZZBUZZ");
            }
            else if (fizz)
            {
                Debug.Log("FIZZ");
            }
            else if (buzz)
            {
                Debug.Log("BUZZ");
            } 
            else
            {
                Debug.Log(i);
            }
        }
    }
}