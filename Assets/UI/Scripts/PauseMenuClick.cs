using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuClick : MonoBehaviour
{
    public void Resume() {
        PauseMenu.gameIsPaused = false;
    }

    public void Restart() {

        SceneManager.LoadScene("Level");
    }

    public void MainMenu() {
        SceneManager.LoadScene("MainMenu");
    }
}
