using UnityEngine;

class ChildrenInLine : MonoBehaviour
{
    void Update()
    {
        Transform[] children = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            children[i] = transform.GetChild(i);
        }

        Transform first = children[0];
        Transform last = children[^1];
        Vector3 firstPoint = first.position;
        Vector3 lastPoint = last.position;
        Quaternion firstRotation = first.rotation;
        Quaternion lastRotation = last.rotation;

        for (int i = 0; i < children.Length; i++)
        {
            Transform t = children[i];
            float rate = (float)i / (children.Length - 1);
            t.position = Vector3.Lerp(firstPoint, lastPoint, rate);
            t.rotation = Quaternion.Lerp(firstRotation, lastRotation, rate);
        }
    }
}
