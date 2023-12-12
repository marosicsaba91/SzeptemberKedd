using UnityEngine;

class Rocket : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed = 5;
    [SerializeField] float angularSpeed = 180;

    void Update()
    {
        Vector3 targetPoint = target.position;

        Vector3 targetDir = targetPoint - transform.position;
        Quaternion targetRot = Quaternion.LookRotation(targetDir);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRot, angularSpeed * Time.deltaTime);

        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
