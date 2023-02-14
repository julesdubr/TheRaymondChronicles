using UnityEngine;

public class PlayCountdown : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioClip musicStart;
    [SerializeField] private float volume = 0.2f;

    private void OnEnable()
    {
        musicSource.PlayOneShot(musicStart);
        musicSource.volume = volume;
    }
}