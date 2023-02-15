using UnityEngine;

public class PlayCelebration : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioClip musicStart;
    [SerializeField] private float volume = 0.2f;

    private void OnEnable()
    {
        if (musicSource.isPlaying)
            musicSource.Stop();
        musicSource.PlayOneShot(musicStart);
        musicSource.volume = volume;
    }
}