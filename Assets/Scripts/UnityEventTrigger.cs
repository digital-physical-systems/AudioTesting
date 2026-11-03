using UnityEngine;
using UnityEngine.Events;

public class UnityEventTrigger : MonoBehaviour
{
    //[SerializeField] private AudioSource myAudioSource;
    [SerializeField] private UnityEvent onTriggerEvent;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //myAudioSource.Play();
            onTriggerEvent?.Invoke();
        }
    }
}
