using System.Collections.Generic;
using UnityEngine;

class ListPractice : MonoBehaviour
{
    [SerializeField] List<string> strings; 

    void Start()
    {
        List<float> floatList = new List<float>();
        floatList.Add(23.44f);
        floatList.Add(37.44f);
        floatList.Add(44.22f);

        float f = floatList[2];
        floatList[0] = 12.66f;

        int count = floatList.Count;  // Darabszám: 3

        bool found = floatList.Remove(23.44f);
        count = floatList.Count;  // Darabszám: 2
        f = floatList[0];         // 37.44f

        floatList.RemoveAt(0);
        count = floatList.Count;  // Darabszám: 1
        f = floatList[0];         // 44.22f

        floatList.Insert(0, 121.3f);
        int index = floatList.IndexOf(44.22f);   // 1
        count = floatList.Count;  // Darabszám: 2

        floatList.Clear();
        count = floatList.Count;  // Darabszám: 0

        List<string> shoppingList = new () { "Tojás", "Körte", "Tej", "Zsemle", "Alma"};
        shoppingList.Sort();   // Sorba rendezés

        for (int i = 0; i < shoppingList.Count; i++)
        {
            string item = shoppingList[i];
            Debug.Log(item);
        }

        foreach (string item in shoppingList)
        {
            Debug.Log(item);
        }
    }
}
