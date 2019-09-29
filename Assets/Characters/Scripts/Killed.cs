using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killed : MonoBehaviour
{
    public GameObject pil;
    public CountRemainingPlayers deathController;

    private void Start() {
        deathController.playerHasAppeared();
    }

    void OnTriggerEnter2D(Collider2D other) {
        
        if (other.gameObject.name == "Killbox") {

            deathController.playerHasDied();

            Destroy(pil);
            Destroy(this.gameObject);

        }
    }
}
