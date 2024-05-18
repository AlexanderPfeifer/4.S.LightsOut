
using UnityEngine;

public class PizzaChoosableGame : Interaction, IChoosableGame
{
    [SerializeField] private GameObject pizzaGame;

    [SerializeField] private int scoreToWin;

    public override void TakeInteractableObject(GameObject interactable)
    {
        base.TakeInteractableObject(interactable);
        interactableObjectPutAwayPosition = transform.position;
    }

    public void OpenGame()
    {
        StartCoroutine(motherBehaviour.NewGameGotPicked(3));
        pizzaGame.SetActive(true);
    }
}