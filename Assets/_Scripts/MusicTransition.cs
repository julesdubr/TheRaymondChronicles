using System;
using System.Collections;
using UnityEngine;

public class MusicTransition : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private float duration;
    [SerializeField] private float targetVolume;

    private void OnEnable()
    {
        StartCoroutine(FadeToCountdown());
    }
    
    private IEnumerator FadeToCountdown()
    {
        float currentTime = 0;
        var start = musicSource.volume;
        
        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            musicSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        musicSource.Stop();
    }
}
