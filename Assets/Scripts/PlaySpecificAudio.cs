using UnityEngine;
using UnityEngine.InputSystem;

public class PlaySpecificAudio : MonoBehaviour
{
    [SerializeField] private AudioSource myAudioSource;
    [SerializeField] private AudioClip specificClip;
    [SerializeField] private float volume = 1f;

    // Update is called once per frame
    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard != null && keyboard.eKey.wasPressedThisFrame)
        {
            myAudioSource.PlayOneShot(specificClip, volume);
        }
    }
}
    