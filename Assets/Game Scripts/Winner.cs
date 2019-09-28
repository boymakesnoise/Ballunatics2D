using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour
{
    //public static bool somebodyWon = false;
    public GameObject winMenu;
    public GameObject winText;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public Button selectButton;

    private void Start() {
        winMenu.SetActive(false);    // Om man glömt stänga av den
        winText.SetActive(false);
        player1.SetActive(false);
        player2.SetActive(false);
        player3.SetActive(false);
        player4.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other) {

        if (other.gameObject.name == "Player1") {

            //Destroy(pil);
            //somebodyWon = true;
            winMenu.SetActive(true);
            winText.SetActive(true);
            player1.SetActive(true);
            Time.timeScale = 0f;
            PauseMenu.gameIsPaused = true;
            selectButton.OnSelect(null);    // Påminn Unity att markera denna knapp
        }
    }
    
}
