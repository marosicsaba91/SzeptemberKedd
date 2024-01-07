using System.Collections.Generic;
using UnityEngine;

class GravityPoint : MonoBehaviour
{
    [SerializeField] float mass;
    Vector3 velocity = Vector3.zero;

    static List<GravityPoint> all = new();

    void OnValidate()
    {
        const float sizeMultiplier = 0.25f;

        float size = Mathf.Pow(mass, 1f / 3);
        transform.localScale = Vector3.one * size * sizeMultiplier;
    }

    void OnEnable() { all.Add(this); }
    void OnDisable() { all.Remove(this); }



    void FixedUpdate()
    {

        Vector3 selfPosition = transform.position;

        foreach (GravityPoint other in all)
        {
            Vector3 otherPosition = other.transform.position;
            Vector3 distanceVector = selfPosition - otherPosition;

            if (distanceVector == Vector3.zero) continue;

            float distance = distanceVector.magnitude;
            Vector3 directionVector = distanceVector / distance; // Lehetne normalizálni is

            // float acceleration = mass / (distance * distance);  // Fizikai
            float acceleration = mass / distance;                  // Nem fizikai, de jobban néz ki
            Vector3 accelerationVector = directionVector * acceleration;
            other.velocity += accelerationVector * Time.fixedDeltaTime; 
        }
    }

    void Update()
    {
        transform.position += velocity * Time.deltaTime;
    }
}
