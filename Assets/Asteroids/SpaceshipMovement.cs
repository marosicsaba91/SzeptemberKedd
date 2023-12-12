using UnityEngine;

class SpaceshipMovement : MonoBehaviour
{
    [SerializeField] float acceleration = 5;
    [SerializeField] float angularSpeed = 360;
    [SerializeField] float maxSpeed = 10;
    [SerializeField] float drag = 1;

    Vector3 velocity = Vector3.zero;

    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        if (xInput != 0)
        {
            // Forgok
            transform.Rotate(0, 0, -xInput * angularSpeed * Time.deltaTime);
        }
         
        transform.position += velocity * Time.deltaTime;
    }

    void FixedUpdate()
    {
        bool moveInput = Input.GetKey(KeyCode.W);
        if (moveInput)
        {
            // Gyorsulok
            Vector3 direction = transform.up;
            velocity += direction * acceleration * Time.fixedDeltaTime;

            if (velocity.magnitude > maxSpeed)
            {
                velocity.Normalize();
                velocity *= maxSpeed;
            }
        }
        else
        {
            // Lassulok
            Vector3 dragVector = -velocity * drag;
            velocity += dragVector * Time.fixedDeltaTime;
        }
    }


}
