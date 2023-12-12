using UnityEngine;

class Gravity : MonoBehaviour
{
    [SerializeField] float acceleration = 9.81f;

    float speed = 0;

    void Update()
    {
        if (transform.position.y <= 0)
        {
            Vector3 p = transform.position;
            p.y = 0;
            transform.position = p;
            speed = 0;
        }
        else 
        {        
            speed += acceleration * Time.deltaTime;
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }
}
