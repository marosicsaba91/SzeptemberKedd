using UnityEngine;

class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        Transform t = transform;

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 inputVector = new Vector3(x, y);
        Vector3 velocity = inputVector * speed;

        t.position += velocity * Time.deltaTime;
    }
}
