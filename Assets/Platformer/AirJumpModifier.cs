using UnityEngine;

class AirJumpModifier : MonoBehaviour
{
    [SerializeField] bool removeJumps = false;
    [SerializeField] bool deleteOnContact = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlatformerController pc))
        {
            if (removeJumps)
                pc.RemoveJumpBudget();
            else
                pc.FillJumpBudget();

            if (deleteOnContact)
                Destroy(gameObject);
        }
    }

}
