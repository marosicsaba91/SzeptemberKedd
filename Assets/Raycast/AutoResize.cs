using UnityEngine;

class AutoResize : MonoBehaviour
{
    [SerializeField] float minSize = 0.2f, maxSize = 2;
    [SerializeField] float density = 1; 

    void Start()
    {
        Transform[] allChildren =
            GetComponentsInChildren<Transform>();

        Transform self = transform;
        foreach (Transform t in allChildren)
        {
            if (t == self) continue;

            float size = Random.Range(minSize, maxSize);
            Vector3 sizeVector = Vector3.one * size;
            t.localScale = sizeVector;

            Rigidbody rb = t.GetComponent<Rigidbody>();
            if (rb != null)
                rb.mass = size * size * size * density;
        }
    }
}
