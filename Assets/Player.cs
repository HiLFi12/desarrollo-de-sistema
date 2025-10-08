using UnityEngine;

public class Player : MonoBehaviour
{
    private PickupFacade pickupFacade;

    void Start()
    {
        AudioSource mainAudioSource = FindObjectOfType<AudioSource>();

        SoundSystem soundSystem = new SoundSystem(mainAudioSource);
        AnimationSystem animationSystem = new AnimationSystem();
        VisualEffectsSystem visualEffectsSystem = new VisualEffectsSystem();

        pickupFacade = new PickupFacade(soundSystem, animationSystem, visualEffectsSystem);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PickupItem>(out PickupItem item))
        {
            pickupFacade.ExecutePickupEffect(other.gameObject.name, item.pickupSound);
            
            Destroy(other.gameObject);
        }
    }
}