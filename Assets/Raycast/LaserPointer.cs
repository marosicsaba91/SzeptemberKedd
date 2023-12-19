using UnityEngine;

class LaserPointer : MonoBehaviour
{
    [SerializeField] Transform[] inBetweenPoints;
    [SerializeField] LayerMask rayCastMask;
    [SerializeField] float maxDistance = 100;


    void Update()
    {
        Vector3 startPoint = transform.position;
        Ray ray = new(startPoint, transform.forward);

        bool isHit = 
            Physics.Raycast(ray, out RaycastHit hit, maxDistance, rayCastMask);

        if (isHit)
        {
            Vector3 endPoint = hit.point;
            Vector3 step = endPoint - startPoint;
            step /= inBetweenPoints.Length - 1;

            foreach (Transform t in inBetweenPoints)
            {
                t.position = startPoint;
                startPoint += step;
            }
        }

        foreach (Transform t in inBetweenPoints)
        {
            if (t.TryGetComponent(out Renderer rend))
                rend.enabled = isHit;
            else
                t.gameObject.SetActive(isHit);
        }
    }



    void OnEnable()
    {
        Debug.Log("Enabled");
    }

    void OnDisable()
    {
        Debug.Log("Disabled");
    }

    void Start()
    {
        Debug.Log("Started");
    }

    void Awake()
    {
        Debug.Log("Awaken");
    }

    void OnDestroy()
    {
        Debug.Log("Destroyed");
    }
}