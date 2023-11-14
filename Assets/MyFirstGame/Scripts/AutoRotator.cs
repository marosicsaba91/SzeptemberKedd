using UnityEngine;

class AutoRotator : MonoBehaviour
{
    [SerializeField] float angularSpeed = 360; //Szögsebesség

    void Update()
    {
        transform.Rotate(0, angularSpeed * Time.deltaTime, 0);
    }
}
