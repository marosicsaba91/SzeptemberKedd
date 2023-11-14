using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] int damage;

    void OnTriggerEnter(Collider other)
    {
        GameObject go = other.gameObject;
        Damageable damageable = go.GetComponent<Damageable>();

        if (damageable != null) 
        {
            damageable.Damage(damage);
        }
    }
}
