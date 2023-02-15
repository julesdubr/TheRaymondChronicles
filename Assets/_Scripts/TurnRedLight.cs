using System;
using UnityEngine;

public class TurnRedLight : MonoBehaviour
{
    [SerializeField] private Material redLight;

    private Light _light;
    private Renderer _renderer;

    private void Awake()
    {
        _light = GetComponentInChildren<Light>();
        _renderer = GetComponentInChildren<Renderer>();
    }

    private void OnEnable()
    {
        _light.color = Color.red;
        _renderer.material = redLight;
    }
}
