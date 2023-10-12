using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Text[] buttonList;
    private string PlayerSide;
    public GameObject gameOverPanel;
    public Text gameOverText;
    private int moveCount;
    public GameObject restartButton;

    void SetGameControllerReferenceOnButton()
    {
        for(int i = 0; i < 9; i++)
        {
            buttonList[i].GetComponentInParent<GridSpace>().SetGameControllerReference(this);
        }
    }
    // Start is called before the first frame update
    void Awake()
    {
        SetGameControllerReferenceOnButton();

        PlayerSide = "O";

        gameOverPanel.SetActive(false); ;
        moveCount = 0;
        restartButton.SetActive(false);
    }

    public string getPlayerSide()
    {
        return PlayerSide;
    }
    public void EndGame()
    {
        
        Debug.Log("it works");


        if(buttonList[0].text==PlayerSide&& buttonList[1].text == PlayerSide && buttonList[2].text == PlayerSide)
        {
            GameOver();
        }
        if (buttonList[3].text == PlayerSide && buttonList[4].text == PlayerSide && buttonList[5].text == PlayerSide)
        {
            GameOver();
        }
        if (buttonList[6].text == PlayerSide && buttonList[7].text == PlayerSide && buttonList[8].text == PlayerSide)
        {
            GameOver();
        }
        if (buttonList[0].text == PlayerSide && buttonList[3].text == PlayerSide && buttonList[6].text == PlayerSide)
        {
            GameOver();
        }
        if (buttonList[1].text == PlayerSide && buttonList[4].text == PlayerSide && buttonList[7].text == PlayerSide)
        {
            GameOver();
        }
        if (buttonList[2].text == PlayerSide && buttonList[5].text == PlayerSide && buttonList[8].text == PlayerSide)
        {
            GameOver();
        }
        if (buttonList[0].text == PlayerSide && buttonList[4].text == PlayerSide && buttonList[8].text == PlayerSide)
        {
            GameOver();
        }
        if (buttonList[2].text == PlayerSide && buttonList[4].text == PlayerSide && buttonList[6].text == PlayerSide)
        {
            GameOver();
        }
        moveCount++;
        if (moveCount == 9)
        {
            gameOverPanel.SetActive(true);
            gameOverText.text = "drAW ";
            restartButton.SetActive(true);
        }
        ChangeSide();
    }
    void GameOver()
    {
        for(int i = 0; i<9; i++)
        {
            buttonList[i].GetComponentInParent<Button>().interactable = false;

        }
        gameOverPanel.SetActive(true);
        gameOverText.text = "Player " + PlayerSide + " wins";
        moveCount = 0;
        restartButton.SetActive(true);
    }
    void ChangeSide()
    {
        PlayerSide = (PlayerSide == "O" ? "X" : "O");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartGame()
    {
        for(int i = 0; i < 9; i++)
        {
            buttonList[i].text = "";
            buttonList[i].GetComponentInParent<Button>().interactable = true;
            
        }
        gameOverPanel.SetActive(false);
        moveCount = 0;
        restartButton.SetActive(false);
    }
}
