using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _shootingInterval;
    private float _timeSinceLastShot;

    // Update is called once per frame
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
        Instantiate(_bulletPrefab, transform.position, transform.rotation);
    }
}
