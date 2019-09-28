using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    public Button selectButton;
    public EventSystem es;

    private int playersLeft = 0;
    private CameraMovement cameraMovement;
    private GameObject storeSelected;

    private void Start() {
        gameOverScreen.SetActive(false);    // Om man glömt stänga av den
        cameraMovement = GameObject.Find("Main Camera").GetComponent<CameraMovement>();

        storeSelected = es.firstSelectedGameObject;
    }

    private void Update() {

        // ej tappa fokus vid musklick
        if (es.currentSelectedGameObject != storeSelected) {
            if (es.currentSelectedGameObject == null) {
                es.SetSelectedGameObject(storeSelected);
            } else {
                storeSelected = es.currentSelectedGameObject;
            }
        }
    }

    public void playerHasDied() {

        playersLeft--;

        if (playersLeft == 0) {
            gameOverScreen.SetActive(true);
            cameraMovement.enabled = false;
            selectButton.OnSelect(null);    // Påminn Unity att markera denna knapp
        }
    }

    public void playerHasAppeared() {
        playersLeft++;
    }

}
