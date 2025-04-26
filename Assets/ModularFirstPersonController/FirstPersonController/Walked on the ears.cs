using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public AudioClip soundClip;  // «вуковий кл≥п
    public AudioSource audioSource;  //  омпонент AudioSource
    private bool isPlaying = false;  // ѕерев≥рка чи звук вже граЇ

    void Start()
    {
        // ќтримуЇмо компонент AudioSource
        audioSource = GetComponent<AudioSource>();

        // ѕерев≥р€Їмо, чи звук був призначений в ≥нспектор≥
        if (soundClip != null)
        {
            audioSource.clip = soundClip;
        }
        else
        {
            Debug.LogError("по трав≥ земл≥");
        }
    }

    void Update()
    {
        // ѕерев≥р€Їмо, чи натиснута клав≥ша 'W'
        if (Input.GetKey(KeyCode.W) && !isPlaying)
        {
            // якщо клав≥ша натиснута ≥ звук ще не граЇ, то в≥дтворюЇмо його
            audioSource.Play();
            isPlaying = true;
        }
        // якщо клав≥ша в≥дпущена
        else if (!Input.GetKey(KeyCode.W) && isPlaying)
        {
            // «упин€Їмо звук
            audioSource.Stop();
            isPlaying = false;
        }
    }
}