using UnityEngine;

public class PlayAudioOnTrigger : MonoBehaviour
{
    [SerializeField] private AudioSource myAudioSource;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            myAudioSource.Play();
    }
}
