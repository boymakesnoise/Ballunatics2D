using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityEngine.EventSystems;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverMenu;
    public Button selectButton;
    public GameObject gameOverText;
    public static bool gameIsOver = false;

    private int playersLeft = 0;
    private CameraMovement cameraMovement;

    private void Start() {
        gameOverMenu.SetActive(false);    // Om man glömt stänga av den
        gameOverText.SetActive(false);
        cameraMovement = GameObject.Find("Main Camera").GetComponent<CameraMovement>();
    }

    public void playerHasDied() {

        playersLeft--;

        if (playersLeft == 0) {
            gameOverMenu.SetActive(true);
            gameOverText.SetActive(true);
            cameraMovement.enabled = false;
            selectButton.OnSelect(null);    // Påminn Unity att markera denna knapp
            gameIsOver = true;
        }
    }

    public void playerHasAppeared() {
        playersLeft++;
    }

    /*
    public void Replay() {
        gameIsOver = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level");
    }

    public void MainMenu() {
        gameIsOver = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    */
}
