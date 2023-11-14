using TMPro;
using UnityEngine;

class PathMover : MonoBehaviour
{
    [SerializeField] Transform t1, t2;
    [SerializeField] float startPoint;
    [SerializeField] float speed;

    Transform currentTarget;

    void Start()
    {
        currentTarget = t2;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            currentTarget.position,
            speed * Time.deltaTime);

        if (transform.position == currentTarget.position)
            currentTarget = currentTarget == t1 ? t2 : t1;
    }

    void OnValidate()
    {
        transform.position = 
           Vector3.Lerp(t1.position, t2.position, startPoint);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 p1 = t1.position;
        Vector3 p2 = t2.position;

        Gizmos.DrawWireSphere(p1, 0.25f);
        Gizmos.DrawWireSphere(p2, 0.25f);
        Gizmos.DrawLine(p1, p2);
    }
}
