using UnityEngine;

class ControlStructures : MonoBehaviour
{
    [SerializeField] int number;

    void Start()
    {
        // Elgazás
        if (number > 0)
        {
            Debug.Log("Pozitív szám");
        }
        else if (number < 0)
        {
            Debug.Log("Negatív szám");
        }
        else
        {
            Debug.Log("A szám Nulla");
        }

        // ----------------------------

        if (number % 2 == 0)
            Debug.Log("PÁROS");
        else
            Debug.Log("PÁRATLAN");


        // ---------------------------

        string isEven;
        if (number % 2 == 0)
            isEven = "EVEN";
        else
            isEven = "ODD";

        isEven = number % 2 == 0 ? "EVEN" : "ODD";

        // ----------------------------

        int i = 1;
        while (i <= 100) 
        {
            Debug.Log(i * i);
            i++;
        }

        for (int j = 100; j > 0; j--)
        {
            Debug.Log(j * j);
        }

        int k = 1;
        do
        {
            Debug.Log(k * k);

        } while (k <= 100);
    }
}
