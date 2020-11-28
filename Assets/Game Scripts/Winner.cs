using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour
{
    //public static bool somebodyWon = false;
    public GameObject winMenu;
    public GameObject winText;
    public GameObject gameoverText;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public Button selectButton;

    private GameObject winningPlayer = null;
    private bool canSelect = true;

    private void Start() {
        winMenu.SetActive(false);    // Om man glömt stänga av den
        winText.SetActive(false);
        gameoverText.SetActive(false);
        player1.SetActive(false);
        player2.SetActive(false);
        player3.SetActive(false);
        player4.SetActive(false);
    }

    //private void Update()
    //{
    //    // BARA 0 SPELARE KVAR -------------------------------------------------
    //    if (CountRemainingPlayers.playersLeft == 0)     // Tidigare == 1
    //    {
    //        //int i = 1;
    //        //while (winningPlayer == null)
    //        //{
    //        //    winningPlayer = GameObject.Find("Player" + i);
    //        //    i++;
    //        //}

    //        //if (winningPlayer.name == "Player1") player1.SetActive(true);
    //        //if (winningPlayer.name == "Player2") player2.SetActive(true);
    //        //if (winningPlayer.name == "Player3") player3.SetActive(true);
    //        //if (winningPlayer.name == "Player4") player4.SetActive(true);

    //        winMenu.SetActive(true);
    //        //winText.SetActive(true);

    //        gameoverText.SetActive(true);

    //        Time.timeScale = 0f;
    //        //PauseMenu.gameIsPaused = true;
    //        CameraMovement.moveCamera = false;
    //        CountRemainingPlayers.gameIsOver = true;
    //        if (canSelect)
    //        {
    //            canSelect = false;
    //            selectButton.OnSelect(null);    // Påminn Unity att markera denna knapp
    //        }
    //    }
    //}

    // 1 SPELARE NÅR MÅNEN -----------------------------------------------------
    void OnTriggerEnter2D(Collider2D other) {

        if (other.gameObject.name == "Player1") {
            player1.SetActive(true);
            ActivateWinScreen();
        }
        if (other.gameObject.name == "Player2") {
            player2.SetActive(true);
            ActivateWinScreen();
        }
        if (other.gameObject.name == "Player3") {
            player3.SetActive(true);
            ActivateWinScreen();
        }
        if (other.gameObject.name == "Player4") {
            player4.SetActive(true);
            ActivateWinScreen();
        }
    }

    private void ActivateWinScreen() {
        winMenu.SetActive(true);
        winText.SetActive(true);
        Time.timeScale = 0f;
        //PauseMenu.gameIsPaused = true;
        CameraMovement.moveCamera = false;
        CountRemainingPlayers.gameIsOver = true;
        selectButton.OnSelect(null);    // Påminn Unity att markera denna knapp
    }
}