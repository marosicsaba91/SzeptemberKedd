using UnityEngine;

class MovementsPractice : MonoBehaviour
{
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        // Fix Velocity
        Vector3 velocity = Vector3.right * 2;
        rb.velocity = velocity;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Fix Velocity Chang
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 velocityChange = Vector3.up * 2;
            rb.velocity += velocityChange;

            // rb.AddForce(velocityChange, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            // Fix Impulse Change
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 impulseChange = Vector3.up * 2;
            rb.velocity += impulseChange / rb.mass;

            // rb.AddForce(impulseChange, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        // Fix gyorsulás
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 acceleration = Vector3.down * 2;
            rb.velocity += acceleration * Time.fixedDeltaTime;

            // rb.AddForce(acceleration, ForceMode.Acceleration);
        }

        // Fix erõt közlünk
        if (Input.GetKey(KeyCode.S))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 acceleration = Vector3.down * 2;
            rb.velocity += acceleration * Time.fixedDeltaTime / rb.mass;

            // rb.AddForce(acceleration);
        }
    }
}
