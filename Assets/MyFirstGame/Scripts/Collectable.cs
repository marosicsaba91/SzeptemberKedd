using UnityEngine;

class Collectable : MonoBehaviour
{
    [SerializeField, Min(1)] int value = 1;
    [SerializeField] Bounds teleportArea;

    public int GetValue() 
    {
        return value;
    }

    public void Teleport()
    {
        float randomX = Random.Range(teleportArea.min.x, teleportArea.max.x);
        float randomY = Random.Range(teleportArea.min.y, teleportArea.max.y);
        float randomZ = Random.Range(teleportArea.min.z, teleportArea.max.z);

        transform.position = new (randomX, randomY, randomZ);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(teleportArea.center, teleportArea.size);        
    }
}