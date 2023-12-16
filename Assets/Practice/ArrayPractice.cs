using System;
using UnityEngine;

class ArrayPractice : MonoBehaviour
{
    [SerializeField] string[] strings1;
    [SerializeField] string searched;

    [SerializeField] int indexOfSearched;
    [SerializeField] string[] reversed;

    void OnValidate()
    {
        indexOfSearched = GetIndex(strings1, searched);
        reversed = GetReversed(strings1);

        indexOfSearched = Array.IndexOf(strings1, searched);
        reversed = new string[strings1.Length];
        Array.Copy(strings1, reversed, strings1.Length);
        Array.Reverse(reversed);

        Array.Sort(reversed);
    }

    int GetIndex(string[] array, string searchFor) 
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == searchFor)
                return i;
        }
        return -1;
    }

    string[] GetReversed(string[] original) 
    {
        string[] reversed = new string[original.Length];
        for (int i = 0; i < original.Length; i++)
        {
            reversed[i] = original[^(i+1)];
        }
        return reversed;
    }


    void Start()
    {
        // T�mb�k
        int a;           // Deklar�l�s
        int[] integers;  // Deklar�l�s

        a = 23;                   // Defini�l�s
        integers = new int[10];   // Defini�l�s

        int[] ints2 = new int[124];   // 124 elem�

        ints2[0] = 21;                // Els� elem = null�s index
        ints2[1] = 34;
        ints2[123] = 5446;            // Utols� elem
        // ints2[124] = 12356;        // ERROR Utols� ut�ni
        // ints2[-1] = 12356;         // ERROR

        string[] strings = new string[] { "Alma", "Barack", "Citrom"};
        Debug.Log(strings[1]);        // Barack
        int length = strings.Length;
        // Utols� elem lek�r
        string last = strings[strings.Length - 1];
        string lastAlter = strings[^1];

        string[] strings2 = { "Alma", "Barack", "Citrom" };  // �gy is megy

        int index1 = GetIndex(strings2, "Barack");   // 1
        int index2 = GetIndex(strings2, "Ban�n");    // -1

        // Int t�mb 100 elem�. �rt�kek 1-100

        int[] ints3 = new int[100];
        for (int i = 0; i < ints3.Length; i++)
        {
            ints3[i] = i + 1;
        }

        // ----------------------------------------

        int x = 12;
        int y = x;
        y += 100;
        Debug.Log(x);            // 12
        Testmethod(x);
        Debug.Log(x);            // 12


        int[] intsA = { 1, 2, 3 };
        int[] intsB = intsA;
        intsB[0] += 100;
        Debug.Log(intsA[0]);     // 101
        TestMethodA(intsA);
        Debug.Log(intsA[0]);     // 201

    }

    void Testmethod(int a)
    {
        a += 100;
    }
    void TestMethodA(int[] a)
    {
        a[0] += 100;
    }

}
