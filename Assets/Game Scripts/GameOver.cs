using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    public Button selectButton;

    private int playersLeft = 0;
    private CameraMovement cameraMovement;
    //private bool gameOver = false;

    private void Start() {
        gameOverScreen.SetActive(false);
        cameraMovement = GameObject.Find("Main Camera").GetComponent<CameraMovement>();
    }
    /*
    private void Update() {
        //if (gameOver && Input.GetKeyDown(KeyCode.Space)) {
        if (gameOver && Input.GetButtonDown("Submit")) {
                SceneManager.LoadScene("Level");
        }
    }
    */
    public void playerHasDied() {

        playersLeft--;

        if (playersLeft == 0) {
            //gameOver = true;
            gameOverScreen.SetActive(true);
            cameraMovement.enabled = false;
            selectButton.OnSelect(null);    // Påminn Unity att markera denna knapp
        }
    }

    public void playerHasAppeared() {
        playersLeft++;
    }

}
