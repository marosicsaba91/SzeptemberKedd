using System;
using System.Collections.Generic;
using UnityEngine;

class Person : MonoBehaviour
{
    [SerializeField] string fullName;
    [SerializeField] int age;
    [SerializeField] float height;
    [SerializeField] bool doesSmoke;

    public static List<Person> persons = new();

    private void Awake()
    {
        persons.Add(this);
    }

    private void OnDestroy()
    {
        persons.Remove(this);
    }

    public void AgeOneYear() 
    {
        age++;
    }

    void Start()
    {
        Person p = FindObjectOfType<Person>();
        p.AgeOneYear();

        Vector3 v = new Vector3();

        v.Normalize();  // NEM Statikus
        float d = Vector3.Distance(v, Vector3.up);   // Statikus

        Rigidbody rb = GetComponent<Rigidbody>();  // NEM Statikus 
        float abs = Mathf.Abs(-34);                // Statikus

        int[] fib = ArrayPractice.GetFibonacci(30);
    }

    public string GetFullName()
    {
        return fullName;
    }
}
