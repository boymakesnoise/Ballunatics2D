using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public Button selectButton;
    public EventSystem es;

    private GameObject storeSelected;

    private void Start() {
        pauseMenuUI.SetActive(false);    // Om man glömt stänga av den
        selectButton.OnSelect(null);    // Påminn Unity att markera denna knapp

        storeSelected = es.firstSelectedGameObject;
    }

    void Update()
    {
        if (Input.GetButtonDown("Pause")) {
            if (gameIsPaused) {
                Resume();
            } else {
                Pause();
            }
        }

        // ej tappa fokus vid musklick
        if (es.currentSelectedGameObject != storeSelected) {
            if (es.currentSelectedGameObject == null) {
                es.SetSelectedGameObject(storeSelected);
            } else {
                storeSelected = es.currentSelectedGameObject;
            }
        }
    }

    void Resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void Pause() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
}
