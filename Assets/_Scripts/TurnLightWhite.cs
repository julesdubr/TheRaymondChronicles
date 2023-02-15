using UnityEngine;

public class TurnLightWhite : MonoBehaviour
{
    [SerializeField] private Material whiteLight;

    private Light _light;
    private Renderer _renderer;

    private void Awake()
    {
        _light = GetComponentInChildren<Light>();
        _renderer = GetComponentInChildren<Renderer>();
    }

    private void OnEnable()
    {
        _light.color = Color.white;
        _renderer.material = whiteLight;
    }
}
