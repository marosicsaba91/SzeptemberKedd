using UnityEngine;

class Practice : MonoBehaviour
{
    [SerializeField] int bulletCount = 10;
    [SerializeField] int magazineCount = 5;
    [SerializeField] int magazineCapacity = 10;

    void Update()
    {
        bool keyPress = Input.GetKeyDown( KeyCode.Space );

        if (keyPress)
        {
            if (bulletCount > 0)
            {
                Debug.Log("Bumm");
                bulletCount--;
            }
            else
            {
                Debug.Log("Klikk");
            }
        }
    }
}
