using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private EnemyHealth _health;
    [SerializeField] private int _dmg;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var playerHealth = collision.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(_dmg);
            _health.TakeDamage(9999);
        }
    }
}
