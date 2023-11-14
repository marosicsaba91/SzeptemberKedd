using UnityEngine;

class Jumper : MonoBehaviour
{
    [SerializeField] float speed = 1;

    Vector3 targetPoint;

    void Start()
    {
        targetPoint = transform.position;
    }

    void Update()
    {
        if (targetPoint == transform.position)
        {
            bool pressRight = Input.GetKeyDown(KeyCode.RightArrow);
            bool pressLeft = Input.GetKeyDown(KeyCode.LeftArrow);
            bool pressUp = Input.GetKeyDown(KeyCode.UpArrow);
            bool pressDown = Input.GetKeyDown(KeyCode.DownArrow);

            Vector3 jump = Vector3.zero;
            if (pressRight)
                jump = Vector3.right;
            else if (pressLeft)
                jump = Vector3.left;
            else if (pressUp)
                jump = Vector3.up;
            else if (pressDown)
                jump = Vector3.down;

            // targetPoint = targetPoint + jump;
            targetPoint += jump;
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPoint, speed * Time.deltaTime);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawSphere(targetPoint, 0.1f);
    }

}
