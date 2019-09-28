using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverClick : MonoBehaviour
{

    public void Replay() {
        SceneManager.LoadScene("Level");
    }

    public void MainMenu() {
        SceneManager.LoadScene("MainMenu");
    }

}
