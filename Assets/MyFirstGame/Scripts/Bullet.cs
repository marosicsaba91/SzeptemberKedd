using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 25f;
    [SerializeField] float destroyDistance = 10;
    [SerializeField] float destroyTime = 2;
    
    Vector3 startPoint;

    void Start()
    {
        startPoint = transform.position;
        Invoke(nameof(DestroySelf), destroyTime);
        // Destroy(gameObject, destroyTime); // Ugyanaz
    }

    void DestroySelf() 
    {
        Destroy(gameObject);
    }

    void Update()
    {
        // Mozgás
        Vector3 globalDir = transform.up;
        transform.position += globalDir * speed * Time.deltaTime;

        // Elpusztítás
        Vector3 point = transform.position;        
        bool isOutOufRange = Vector3.Distance(point, startPoint) > destroyDistance;
        if (isOutOufRange)
        {
            DestroySelf();
            return;
        }
    }
}
