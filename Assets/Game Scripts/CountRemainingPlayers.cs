using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountRemainingPlayers : MonoBehaviour
{
    public static bool gameIsOver = false;
    public static int playersLeft = 0;

    private void Awake() {
        gameIsOver = false;
        playersLeft = 0;
    }

    public void playerHasDied() {

        playersLeft--;

        if (playersLeft == 0) {
            gameIsOver = true;
        }
    }

    public void playerHasAppeared() {
        playersLeft++;
    }

    private void Update() {
        print(gameIsOver);
    }
}