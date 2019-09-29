using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuOptions : MonoBehaviour
{
    public EventSystem es;

    private GameObject storeSelected;

    private void Start() {
        storeSelected = es.firstSelectedGameObject;
    }

    private void Update() {
        if (es.currentSelectedGameObject != storeSelected) {
            if (es.currentSelectedGameObject == null) {
                es.SetSelectedGameObject(storeSelected);
            } else {
                storeSelected = es.currentSelectedGameObject;
            }
        }
    }

    public void Restart() {
        Time.timeScale = 1f;
        PauseMenu.gameIsPaused = false;
        CameraMovement.moveCamera = true;
        CountRemainingPlayers.gameIsOver = false;
        SceneManager.LoadScene("Level");
    }

    public void MainMenu() {
        Time.timeScale = 1f;
        PauseMenu.gameIsPaused = false;
        CameraMovement.moveCamera = true;
        CountRemainingPlayers.gameIsOver = false;
        SceneManager.LoadScene("MainMenu");
    }
}
