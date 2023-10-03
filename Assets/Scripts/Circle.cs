using UnityEngine;

class Circle : MonoBehaviour
{
    [SerializeField] float radius = 12;
    /*
    [SerializeField] string kismacska;
    [SerializeField] int testIntField;
    [SerializeField] bool testBoolField;
    */
    void Start()
    {
        // float radius = 7;

        float circumference = 2 * radius * Mathf.PI;
        float area = Mathf.Pow(radius, 2) * Mathf.PI;

        Debug.Log($"Circumference: {circumference}");
        Debug.Log($"Area: {area}");
    }
}
