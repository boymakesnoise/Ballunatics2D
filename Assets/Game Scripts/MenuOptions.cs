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
        //if (GameObject.Find("DontDestroy")) {
        //    print("hittad!!!!!");
        //}
    }

    public void Restart() {
        Time.timeScale = 1f;
        PauseMenu.gameIsPaused = false;
        CameraMovement.moveCamera = true;
        CountRemainingPlayers.gameIsOver = false;
        FindObjectOfType<AudioManager>().Stop("AmbienceBirds");
        FindObjectOfType<AudioManager>().Stop("AmbienceWind");
        FindObjectOfType<AudioManager>().Stop("AmbienceSpace");
        SceneManager.LoadScene("Level");
    }

    public void MainMenu() {
        Time.timeScale = 1f;
        PauseMenu.gameIsPaused = false;
        CameraMovement.moveCamera = true;
        CountRemainingPlayers.gameIsOver = false;
        FindObjectOfType<AudioManager>().Stop("AmbienceBirds");
        FindObjectOfType<AudioManager>().Stop("AmbienceWind");
        FindObjectOfType<AudioManager>().Stop("AmbienceSpace");
        PlayerArray.activePlayers.Clear();          // Töm listan på spelare
        Destroy(GameObject.Find("DontDestroy"));    // Förstör objektet som har listan på sig
        SceneManager.LoadScene("MainMenu");
    }
}
