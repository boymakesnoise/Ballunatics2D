using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public GameObject sikte1;
    public GameObject sikte2;
    public GameObject sikte3;
    public GameObject sikte4;

    void Start()
    {
        // read players from list and spawn them
        if (PlayerArray.activePlayers.Contains(1)) {
            player1.SetActive(true);
            sikte1.SetActive(true);
            //CountRemainingPlayers.deathController.playerHasAppeared();
        }
        if (PlayerArray.activePlayers.Contains(2)) {
            player2.SetActive(true);
            sikte2.SetActive(true);
        }
        if (PlayerArray.activePlayers.Contains(3)) {
            player3.SetActive(true);
            sikte3.SetActive(true);
        }
        if (PlayerArray.activePlayers.Contains(4)) {
            player4.SetActive(true);
            sikte4.SetActive(true);
        }
    }

}
