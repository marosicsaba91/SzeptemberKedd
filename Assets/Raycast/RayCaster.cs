using UnityEngine;

class RayCaster : MonoBehaviour
{
    [SerializeField] Transform cursor3D;
    [SerializeField] ParticleSystem visualEffect;
    [SerializeField] float explosionRange = 10;
    [SerializeField] float explosionMaxForce = 100;

    void Update()
    {
        Ray mouseRay = 
            Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(mouseRay, out RaycastHit hit)) 
        {
            cursor3D.position = hit.point;
            if (Input.GetMouseButtonDown(0)) 
            {
                Explode(hit.point);
            }
        }
    }

    void Explode(Vector3 position)
    {
        visualEffect.Play();

        Rigidbody[] allRigidBodies = FindObjectsOfType<Rigidbody>();
        foreach (Rigidbody rb in allRigidBodies)
        {
            Vector3 distanceVector = rb.position - position;
            float distance = distanceVector.magnitude;
            if (distance < explosionRange)
            {
                Vector3 directionVector = distanceVector.normalized;
                float explosionForce = explosionMaxForce * (1 - (distance / explosionRange));
                Vector3 explosionForceVector = directionVector * explosionForce;
                rb.AddForce(explosionForceVector);
            }
        }
    }
}
