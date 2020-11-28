using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSelect : MonoBehaviour
{

    public int playerNumber;
    public Image image;

    private string selectButton;
    private bool canSelect = true;

    private void Start()
    {
        selectButton = "P" + playerNumber + "jump";
    }

    private void Update()
    {
        if (Input.GetAxisRaw(selectButton) >= 0.5f && canSelect) {
            canSelect = false;

            // set alpha = 1
            var tempColor = image.color;
            tempColor.a = 1f;
            image.color = tempColor;

            // lägg till spelarnumret i listan
            PlayerArray.activePlayers.Add(playerNumber); 
        }

        if (Input.GetAxisRaw(selectButton) < 0.5f) {
            canSelect = true;
        }

        if (Input.GetButtonDown("Submit") && PlayerArray.activePlayers.Count > 0) {     // used to be Count > 1 (for a min. of 2 players)
            FindObjectOfType<AudioManager>().Stop("Music");
            //FindObjectOfType<AudioManager>().Play("AmbienceBirds");
            SceneManager.LoadScene("Level");
        }
        
    }
}
