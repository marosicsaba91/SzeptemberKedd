using UnityEngine;

class DirectionGizmos : MonoBehaviour
{
    [SerializeField] float size = 5;

    void OnDrawGizmos()
    {
        DrawAxis(transform.right, Color.red);
        DrawAxis(transform.up, Color.green);
        DrawAxis(transform.forward, Color.blue);
    }

    void DrawAxis(Vector3 dir, Color color)
    {
        Vector3 center = transform.position;

        Vector3 p1 = center + (dir * size / 2);
        Vector3 p2 = center - (dir * size / 2);
        Gizmos.color = color;
        Gizmos.DrawLine(p1, p2);
        Gizmos.DrawSphere(p1, 0.025f * size);
    }
}
