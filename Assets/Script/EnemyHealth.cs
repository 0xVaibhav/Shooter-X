using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    int currentHealth;
    [SerializeField] int startHealth = 5;

    void Awake()
    {
        currentHealth = startHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
        }

    }
}
