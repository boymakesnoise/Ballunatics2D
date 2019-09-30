using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenuClick : MonoBehaviour
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

    public void Play() {
        SceneManager.LoadScene("Lobby");
    }

    public void Quit() {
        Application.Quit();
    }
}
