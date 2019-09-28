using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour
{
    public void Restart() {
        Time.timeScale = 1f;
        PauseMenu.gameIsPaused = false;
        GameOver.gameIsOver = false;
        SceneManager.LoadScene("Level");
    }

    public void MainMenu() {
        Time.timeScale = 1f;
        PauseMenu.gameIsPaused = false;
        GameOver.gameIsOver = false;
        SceneManager.LoadScene("MainMenu");
    }
}
