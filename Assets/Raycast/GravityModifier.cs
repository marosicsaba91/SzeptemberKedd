using System.Collections.Generic;
using UnityEngine;

class GravityModifier : MonoBehaviour
{
    [SerializeField] Vector3 acceleration;

    List<Rigidbody> rigidBodies = new();

    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Rigidbody>(out var rb))
            rigidBodies.Add(rb);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<Rigidbody>(out var rb))
            rigidBodies.Remove(rb);
    }

    void FixedUpdate()
    {
        for (int i = rigidBodies.Count - 1; i >= 0; i--)
        {
            Rigidbody rb = rigidBodies[i];

            if (rb != null)
                rb.velocity += acceleration * Time.fixedDeltaTime;
            else
                rigidBodies.Remove(null);
        }
    }
}
