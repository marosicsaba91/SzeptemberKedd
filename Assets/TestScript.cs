using UnityEngine;

class TestScript : MonoBehaviour
{
    void Start()
    {
        // Szia! Csabi vagyok

        /* Komment */

        /* T�bb
         Soros
        Komment */
        
        Debug.Log("Hello Unity!");
        Debug.Log($"Hello {name}!");

        // --------------------------

        // V�ltoz�k
        int myFirstVariable;
        myFirstVariable = 76;

        Debug.Log(myFirstVariable);  // 76
        myFirstVariable = 7;
        Debug.Log(myFirstVariable);  // 7

        int myInt = 5; // Integer  = Eg�sz sz�m
        float myFloat = 45.67f; // Floating Point = Tizedes t�rt sz�m
        string myText = "khns�rohn";  // String = Sz�veg
        bool myBool1 = true;  // Logical type = Eld�ntend� t�pus

        bool myBool2 = false;
        myBool2 = true;

        //hnldmgnkmfvblnkmfgl

    }
}