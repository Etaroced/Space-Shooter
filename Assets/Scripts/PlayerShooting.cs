using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _shootingInterval;
    [SerializeField] private Vector3 _bulletSpawnOffset;

    private float _timeSinceLastShot;


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            UpdateFiring();
        }
    }

    private void UpdateFiring()
    {
        if (Time.time - _timeSinceLastShot > _shootingInterval)
        {
            Shoot();
            _timeSinceLastShot = Time.time;
        }
    }

    private void Shoot()
    {
        var buttlet = Instantiate(_bulletPrefab, transform.position + _bulletSpawnOffset, transform.rotation);
    }
}
