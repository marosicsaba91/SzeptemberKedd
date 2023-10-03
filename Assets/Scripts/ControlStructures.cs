using UnityEngine;

class ControlStructures : MonoBehaviour
{
    [SerializeField] int number;

    void Start()
    {
        // Elgaz�s
        if (number > 0)
        {
            Debug.Log("Pozit�v sz�m");
        }
        else if (number < 0)
        {
            Debug.Log("Negat�v sz�m");
        }
        else
        {
            Debug.Log("A sz�m Nulla");
        }

        // ----------------------------

        if (number % 2 == 0)
            Debug.Log("P�ROS");
        else
            Debug.Log("P�RATLAN");


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
