using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;

    private int playersLeft = 0;
    private CameraMovement cameraMovement;
    private bool gameOver = false;

    private void Start() {
        gameOverScreen.SetActive(false);
        cameraMovement = GameObject.Find("Main Camera").GetComponent<CameraMovement>();
    }

    private void Update() {
        if (gameOver && Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void playerHasDied() {
        playersLeft--;

        if (playersLeft == 0) {
            gameOver = true;
            gameOverScreen.SetActive(true);
            cameraMovement.enabled = false;
        }
    }

    public void playerHasAppeared() {
        playersLeft++;
    }

}
