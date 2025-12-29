using UnityEngine;

public class Blinking : MonoBehaviour
{
    private SpriteRenderer _spr;
    void Start()
    {
        _spr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        _spr.enabled = !_spr.enabled;
    }
}
