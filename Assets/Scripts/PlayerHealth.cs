using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 3;
    [SerializeField] private float invincibilityDuration = 1f;
    [SerializeField] private float flashDuration = 0.1f;
    private int currentHealth;
    private bool isInvincible = false;
    private SpriteRenderer spriteRenderer;

    public static event System.Action OnPlayerDied;

    void Start()
    {
        currentHealth = maxHealth;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(int damage)
    {
        if (isInvincible)
            return;
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
        else
        {
            StartCoroutine(DamageFlash());
        }
    }

    private void Die()
    {
        OnPlayerDied?.Invoke();
        gameObject.SetActive(false);
    }

    private IEnumerator DamageFlash()
    {
        isInvincible = true;
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(flashDuration);
        spriteRenderer.color = Color.white;
        yield return new WaitForSeconds(invincibilityDuration - flashDuration);
        isInvincible = false;
    }
}