using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private GameObject _explosionEffectPrefab;
    [SerializeField] private int _maxHealth;
    private int _currentHealth;

    private void Start() => _currentHealth = _maxHealth;

    public void TakeDamage(int damage)
    {
        if (_currentHealth <= 0) return;
        _currentHealth -= damage;
        if (_currentHealth <= 0) Die();
    }

    protected virtual void Die()
    {
        var explosion = Instantiate(_explosionEffectPrefab, transform.position, transform.rotation);
        Destroy(explosion, 1);
        Destroy(gameObject);
    }
}
