using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    void Update()
    {
        var pos = transform.position;
        pos.y += _speed * Time.deltaTime;
        transform.position = pos;
    }
}
