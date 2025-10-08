using UnityEngine;

public class PickupFacade
{
    private SoundSystem soundSystem;
    private AnimationSystem animationSystem;
    private VisualEffectsSystem visualEffectsSystem;

    public PickupFacade(SoundSystem soundSys, AnimationSystem animSys, VisualEffectsSystem visualSys)
    {
        this.soundSystem = soundSys;
        this.animationSystem = animSys;
        this.visualEffectsSystem = visualSys;
    }

    public void ExecutePickupEffect(string itemName, AudioClip pickupSound)
    {
        Debug.Log($"Efectos de recolección para {itemName}");
        
        soundSystem.PlaySound(pickupSound);
        
        animationSystem.PlayAnimation(itemName + "_pickup_animation");
        visualEffectsSystem.PlayEffect(itemName + "_pickup_vfx");
    }
}