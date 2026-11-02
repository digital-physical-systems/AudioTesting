using UnityEngine;
using UnityEngine.InputSystem;

public class PlayingAudioSource : MonoBehaviour
{
    [SerializeField] private AudioSource myAudioSource;

    // Update is called once per frame
    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard != null && keyboard.eKey.wasPressedThisFrame)
        {
            myAudioSource.Play();
        }
    }
}
