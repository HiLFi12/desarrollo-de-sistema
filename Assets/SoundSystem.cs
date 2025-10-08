using UnityEngine;

public class SoundSystem
{
    private AudioSource audioSource;

    public SoundSystem(AudioSource source)
    {
        this.audioSource = source;
    }
    public void PlaySound(AudioClip clipToPlay)
    {
        if (audioSource != null && clipToPlay != null)
        {
            audioSource.PlayOneShot(clipToPlay);
            Debug.Log($"Reproduciendo sonido: {clipToPlay.name}");
        }
    }
}