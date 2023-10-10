using UnityEngine;

class VectorPractice : MonoBehaviour
{
    void Start()
    {

        Vector2 v2_a = new Vector2();         // (0,0)
        Vector2 v2_b = new Vector2(2, 3);     // (2,3)

        Vector3 v3_a = new Vector3();         // (0,0,0)
        Vector3 v3_b = new Vector3(2, 4, 7);  // (2,4,7)

        Vector3 v3_c = new(2, 4, 7);  // (2,4,7)

        float x = v2_a.x;
        float y = v2_a.y;

        v2_a.x = 7;
        v2_a.y = 0;
                
        Debug.Log(v2_a);

        // -------------------------

        Vector2 v2_c = v2_a + v2_b;
        Vector2 v2_d = v2_a - v2_b;
        Vector2 v2_e = v2_a * 2f;
        Vector2 v2_f = v2_a / 2f;
        float length = v2_a.magnitude;   // float
        Vector2 v2_g = v2_a.normalized;  // Vector

        // --------------------------

        Vector2 v2_h = new Vector3(1, 2);
        Vector3 v3_h = new Vector2(1, 2);

        Vector3 v3_i = v3_a + v3_b;
        Vector3 v3_j = v3_a + (Vector3)v2_a;
    }
}
