using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenu;
    public Button selectButton;
    public GameObject pauseText;

    private void Start() {
        pauseMenu.SetActive(false);    // Om man glömt stänga av den
        pauseText.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("Pause") && !GameOver.gameIsOver) {
            if (gameIsPaused) {
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void Resume() {
        pauseMenu.SetActive(false);
        pauseText.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void Pause() {
        pauseMenu.SetActive(true);
        pauseText.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        selectButton.OnSelect(null);    // Påminn Unity att markera denna knapp
    }
    


    
}
