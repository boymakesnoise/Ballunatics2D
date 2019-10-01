using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWindSFX : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
            if (other.gameObject.name == "Player1"
            || other.gameObject.name == "Player2"
            || other.gameObject.name == "Player3"
            || other.gameObject.name == "Player4") {
                FindObjectOfType<AudioManager>().Stop("AmbienceBirds");
                FindObjectOfType<AudioManager>().Play("AmbienceWind");
                Destroy(gameObject);
            }
    }
}