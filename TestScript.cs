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

        // --- Számok mûveletei -------------------------------

        int i1 = 12;
        int i2 = 5;

        int i3 = i1 + i2;  // 17
        int i4 = i1 - i2;  // 7
        int i5 = i1 * i2;  // 60
        int i6 = i1 / i2;  // 2   (Levágja a végét)

        float f0 = i1;    // Automatikus átalakítás
        int i7 = (int)f0; // Explicit kasztolás
        float f1 = i1 / (float)i2;  // Szükséges

        int i8 = i1 % i2;  // Modulo (Maradék)    2

        int i9 = 13 % 4;   // 1
        int i10 = 33 % 10; // 3




        // -------------------

        int a, b, c;

        a = 5;
        b = 3;
        c = a + b;
        Debug.Log(c);  // 8

        c = 2;
        Debug.Log(c);  // 2

        // --------------------

        a = a + b;   // 8
        a = a + b;   // 11

        a = -b;   // -3

        int lövedék = 10;
        lövedék = lövedék - 1;


        // Rövidítések

        a += b;   // a = a + b;
        a -= b;   // a = a - b;
        a *= b;   // a = a * b;
        a /= b;   // a = a / b;
        a %= b;   // a = a % b;

        a = a - 1;
        a--;
        // --a;   Még ne

        a = a + 1;
        a++;

        // ---------------------

        a = 2;
        b = 3;
        c = 5;

        int i11 = a + b * c; // 17
        int i12 = 2 - ((a + b) * c); // Átzárójelezhetõ
        Debug.Log(i11);

        float f3 = 2 / 3f;

        //--- String mûveletek -----------------------

        string s1 = "alma";
        string s2 = "banán";

        string s3 = s1 + ", " + s2;  // "alma, banán"
        string s4 = $"{s1}, {s2}";   // "alma, banán"

        string s5 = f3.ToString();    // "0.6666666"

        string s6 = f3 + s1;          // "0.66666alma"

        float f4 = float.Parse(s5);
        // float i13 = int.Parse(s1);     // ERROR

        //--- Bool mûveletek -----------------------

        i1 = 12;

        bool b1 = i1 > i2;
        bool b2 = 3 > 12;    // false
        bool b3 = 3 < 12;    // true
        bool b4 = 3 < 3;     // false
        bool b5 = 3 == 4;    // false     // Egyenlõ-e
        bool b6 = i1 == 10;  // false
        bool b7 = i1 != 10;  // true

        bool b8 = 3 >= 3;    // true    // Nagyobb vagy egyenlõ
        bool b9 = 3 <= 3;    // true    // Kisebb vagy egyenlõ

        s1 = "alma";
        s2 = "banán";
        bool b10 = s1 == "alma";  // true
        bool b11 = s1 != "alma";  // false
        bool b12 = s2 == "alma";  // false
        bool b13 = s3 != "alma";  // true

        bool b14 = b10 && b11;    // ÉS

        int lövedékekSzáma = 10;
        float mennyiIdõTeltEl = 1.2f;
        //...
        bool tudunkELõni =
            (lövedékekSzáma > 0) && (mennyiIdõTeltEl > 1);

        bool b15 = b10 || b11;     // VAGY

        bool levegõbenVagyunkE = false;
        bool tudunkELevegõbenUgrani = true;

        bool tudunkEUgrani =
            !levegõbenVagyunkE || tudunkELevegõbenUgrani;

        bool b16 = !b10;
    }
}