using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelect : MonoBehaviour
{

    public int playerNumber;
    public Image image;

    private string selectButton;
    private bool canSelect = true;

    private void Start()
    {
        selectButton = "P" + playerNumber + "jump";
        //image = GetComponent<Image>();
    }

    private void Update()
    {
        if (Input.GetAxisRaw(selectButton) >= 0.5f && canSelect) {
            canSelect = false;
            // alpha = 1
            var tempColor = image.color;
            tempColor.a = 1f; //1f makes it fully visible, 0f makes it fully transparent.
            image.color = tempColor;
        }

        if (Input.GetAxisRaw(selectButton) < 0.5f) {
            canSelect = true;
        }
        
    }
}
