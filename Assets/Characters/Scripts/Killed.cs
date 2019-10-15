using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killed : MonoBehaviour
{
    public GameObject pil;
    public CountRemainingPlayers deathController;
    public GameObject blood;

    private void Start() {
        deathController.playerHasAppeared();
    }

    void OnTriggerEnter2D(Collider2D other) {
        
        if (other.gameObject.name == "Killbox") {

            deathController.playerHasDied();

            FindObjectOfType<AudioManager>().Play("PlayerDeath");

            // Spawn blood-particle-system
            Instantiate(blood, transform.position, transform.rotation);

            Destroy(pil);
            Destroy(this.gameObject);

        }
    }
}
