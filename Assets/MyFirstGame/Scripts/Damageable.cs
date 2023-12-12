using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] int startHealth = 10;
    [SerializeField] TMP_Text uiText;

    int currentHealth;

    public int GetCurrentHealth()
    {
        return currentHealth;
    }

    public bool IsDead() 
    {
        return currentHealth <= 0;
    }

    void Start()
    {
        currentHealth = startHealth;

        UpdUIText();
    }

    public void Damage(int damage)
    {
        if (currentHealth <= 0)
            return;

        currentHealth -= damage;
        currentHealth = Mathf.Max(0, currentHealth);

        if (currentHealth <= 0)
        {
            GameManager gm = FindAnyObjectByType<GameManager>();
            gm.OnGameEnded();
        }

        UpdUIText();
    }

    void UpdUIText()
    {
        if(uiText != null)
            uiText.text = "Health: " + currentHealth.ToString();
    }
}
