using TMPro;
using UnityEngine;

class Collector : MonoBehaviour
{
    [SerializeField] TMP_Text uiText;
    int collectedValue = 0;

    void Start()
    {
        UpdateUI();
    }

    void OnTriggerEnter(Collider other)
    {
        Collectable collectable = other.GetComponent<Collectable>();
        if (collectable != null) 
        {
            collectedValue += collectable.GetValue();
            collectable.Teleport();
            UpdateUI();
        }        
    }

    void UpdateUI()
    {
        if(uiText != null)
            uiText.text = collectedValue.ToString();
    }
}