using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;

    private int playersLeft = 0;
    private CameraMovement cameraMovement;

    private void Start() {
        gameOverScreen.SetActive(false);
        cameraMovement = GameObject.Find("Main Camera").GetComponent<CameraMovement>();
    }

    public void playerHasDied() {
        playersLeft--;
        //print(playersLeft);

        if (playersLeft == 0) {
            // Enable GAME OVER UI menu here
            gameOverScreen.SetActive(true);
            cameraMovement.enabled = false;
        }
    }

    public void playerHasAppeared() {
        playersLeft++;
        //print(playersLeft);
    }

}
