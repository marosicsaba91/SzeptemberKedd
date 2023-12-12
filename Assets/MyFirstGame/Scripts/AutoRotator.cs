using UnityEngine;

class AutoRotator : MonoBehaviour
{
    [SerializeField] float minAngularSpeed = 0; 
    [SerializeField] float maxAngularSpeed = 360;
    [SerializeField] Space space = Space.Self;

    float angularSpeed; //Szögsebesség

    void Start()
    {
        angularSpeed = Random.Range(minAngularSpeed, maxAngularSpeed);
    }

    void Update()
    {
        transform.Rotate(0, angularSpeed * Time.deltaTime, 0, space);
    }
}
