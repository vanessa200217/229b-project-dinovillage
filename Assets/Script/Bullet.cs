using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 1.5f;
    public int damage = 1;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage); 
            }

            Destroy(gameObject); 
            void OnTriggerEnter2D(Collider2D other)
            {
                Debug.Log("Bullet hit: " + other.name); // จะบอกว่าโดนอะไร

                if (other.CompareTag("Enemy"))
                {
                    Enemy enemy = other.GetComponent<Enemy>();
                    if (enemy != null)
                    {
                        enemy.TakeDamage(damage);
                    }

                    Destroy(gameObject);
                }
            }
        }
    }
}