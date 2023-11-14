using UnityEngine;

class Follower : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed;
    [SerializeField] float maxDistance = 2;

    void Update()
    {
        Vector3 selfPosition = transform.position;
        Vector3 targetPosition = target.position;

        Vector3 directionVector = targetPosition - selfPosition;
        // float distance = directionVector.magnitude;
        float distance = Vector3.Distance(selfPosition, targetPosition);

        if (distance < maxDistance) return;


        directionVector.Normalize();

        if (directionVector == Vector3.zero) return;

        transform.position = Vector3.MoveTowards(
            selfPosition,
            targetPosition,
            speed * Time.deltaTime);

        transform.rotation = Quaternion.LookRotation(directionVector);
    }
}
