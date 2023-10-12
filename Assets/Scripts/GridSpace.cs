using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour
{
    public Text buttonText;
    public Button thebutton;
    private GameController gameController;
    public string PlayerSide;

    // Start is called before the first frame update
    public void SetGameControllerReference(GameController controller)
    {
        gameController = controller;
    }

    public void SetSpace()
    {
        buttonText.text = gameController.getPlayerSide();
        thebutton.interactable = false;
        gameController.EndGame(); 


    }
}
