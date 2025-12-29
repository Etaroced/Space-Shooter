using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private GameObject _explosionEffectPrefab;
    private void OnTriggerEnter2D(Collider2D collision) => Die();
    private void Die()
    {
        var explosion = Instantiate(_explosionEffectPrefab, transform.position, transform.rotation);
        Destroy(explosion, 1);
        Destroy(gameObject);
    }
}
