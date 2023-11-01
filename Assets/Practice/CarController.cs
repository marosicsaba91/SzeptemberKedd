using UnityEngine;

class CarController : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float angularSpeed = 180;

    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");

        Vector3 direction = transform.forward * forwardInput;
        transform.position += direction * speed * Time.deltaTime;

        float rotationInput = Input.GetAxis("Horizontal");
        float rotationDirection = rotationInput * forwardInput;

		transform.Rotate(0, rotationDirection * angularSpeed * Time.deltaTime, 0);

        Vector3 f = Vector3.forward;   // (0,0,1)
        Vector3 b = Vector3.back;      // (0,0,-1)

		Vector3 sf = transform.forward;   // (???, ???, ???)
		Vector3 su = transform.up;        // (???, ???, ???)
		Vector3 sr = transform.right;     // (???, ???, ???)

		Vector3 sb = -transform.forward;


	}
}
