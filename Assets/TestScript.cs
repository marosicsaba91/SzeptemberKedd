using UnityEngine;

class TestScript : MonoBehaviour
{
    void Start()
    {
        // Szia! Csabi vagyok

        /* Komment */

        /* Több
         Soros
        Komment */
        
        Debug.Log("Hello Unity!");
        Debug.Log($"Hello {name}!");

        // --------------------------

        // Változók
        int myFirstVariable;
        myFirstVariable = 76;

        Debug.Log(myFirstVariable);  // 76
        myFirstVariable = 7;
        Debug.Log(myFirstVariable);  // 7

        int myInt = 5; // Integer  = Egész szám
        float myFloat = 45.67f; // Floating Point = Tizedes tört szám
        string myText = "khnsérohn";  // String = Szöveg
        bool myBool1 = true;  // Logical type = Eldöntendõ típus

        bool myBool2 = false;
        myBool2 = true;

        //hnldmgnkmfvblnkmfgl

    }
}