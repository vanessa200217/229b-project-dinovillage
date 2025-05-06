using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damageToPlayer = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Health player = other.GetComponent<Health>();
            if (player != null)
            {
                player.TakeDamage(damageToPlayer);
            }
        }
    }
}
