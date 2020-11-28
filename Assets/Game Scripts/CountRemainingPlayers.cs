using UnityEngine;
using UnityEngine.UI;

public class CountRemainingPlayers : MonoBehaviour
{
    public static bool gameIsOver = false;
    public static int playersLeft = 0;

    public GameObject winMenu;
    public GameObject gameoverText;
    public Button selectButton;

    private bool canSelect = true;

    private void Awake() {
        gameIsOver = false;
        playersLeft = 0;
    }

    public void playerHasDied() {

        playersLeft--;

        if (playersLeft == 0) {
            gameIsOver = true;

            ShowGameOverScreen();
        }
    }

    public void playerHasAppeared() {
        playersLeft++;
    }

    private void Update() {
        //print(gameIsOver);
        //print("Players left: " + playersLeft);
    }

    private void ShowGameOverScreen()
    {
        winMenu.SetActive(true);

        gameoverText.SetActive(true);

        Time.timeScale = 0f;
        CameraMovement.moveCamera = false;
        CountRemainingPlayers.gameIsOver = true;
        if (canSelect)
        {
            canSelect = false;
            selectButton.OnSelect(null);    // Påminn Unity att markera denna knapp
        }
    }
}