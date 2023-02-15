using System.Collections;
using UnityEngine;

public class FadeScreen : MonoBehaviour
{
    [SerializeField] private bool fadeOnStart = true;
    [SerializeField] private Color fadeColor;
    public float fadeDuration;

    private Renderer _renderer;
    private static readonly int Color1 = Shader.PropertyToID("_BaseColor");

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        if (fadeOnStart)
            FadeIn();
    }

    private void FadeIn()
    {
        Fade(1, 0);
    }
    
    public void FadeOut()
    {
        Fade(0, 1);
    }

    private void Fade(float alphaIn, float alphaOut)
    {
        StartCoroutine(FadeRoutine(alphaIn, alphaOut));
    }

    private IEnumerator FadeRoutine(float alphaIn, float alphaOut)
    {
        float timer = 0;
        while (timer <= fadeDuration)
        {
            Color newColor = fadeColor;
            newColor.a = Mathf.Lerp(alphaIn, alphaOut, timer / fadeDuration);
            _renderer.material.SetColor(Color1, newColor);
            
            timer += Time.deltaTime;
            yield return null;
        }

        Color lastColor = fadeColor;
        lastColor.a = alphaOut;
        _renderer.material.SetColor(Color1, lastColor);
    }
}
