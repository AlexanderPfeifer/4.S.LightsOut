using UnityEngine;
using UnityEngine.Rendering;

public class Console : Interaction
{
    private Vector3 putAwayPos;
    [SerializeField] private Volume consoleHoldVolume;

    //assigns the position of where the objects are held in front of the player and the put away position and activates a blur effect
    private void Start()
    {
        var position = transform.position;
        interactableObjectInHandPosition = position;

        consoleHoldVolume.weight = 1;
        
        putAwayPos = new Vector3(position.x + 3, position.y - 3, position.z + 3);
    }
    
    //Takes the object and activates blur effect
    public override void TakeInteractableObject(GameObject interactable)
    {
        base.TakeInteractableObject(interactable);
        consoleHoldVolume.weight = 1;
    }

    //Assigns the put down position of the console
    public override void AssignPutDownPos()
    {
        interactableObjectPutAwayPosition = putAwayPos;
    }

    //Puts down console to put down position and deactivates blur effect
    public override void PutDownInteractableObject(GameObject interactable)
    {
        base.PutDownInteractableObject(interactable);
        consoleHoldVolume.weight = 0;
    }
}
