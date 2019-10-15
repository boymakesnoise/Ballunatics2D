using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySpaceSFX : MonoBehaviour {

    public float spaceGravity = 0.5f;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    private bool canPlaySpaceSounds = true;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "Player1"
        || other.gameObject.name == "Player2"
        || other.gameObject.name == "Player3"
        || other.gameObject.name == "Player4") {
            if (canPlaySpaceSounds) {
                FindObjectOfType<AudioManager>().Stop("AmbienceWind");
                FindObjectOfType<AudioManager>().Play("AmbienceSpace");
                canPlaySpaceSounds = false;     // start only once
            }

            //// Minska gravity
            //player1.GetComponent<Rigidbody2D>().gravityScale = spaceGravity;
            //player2.GetComponent<Rigidbody2D>().gravityScale = spaceGravity;
            //player3.GetComponent<Rigidbody2D>().gravityScale = spaceGravity;
            //player4.GetComponent<Rigidbody2D>().gravityScale = spaceGravity;

            //Destroy(gameObject);
        }

        if (other.gameObject.name == "Player1")
            player1.GetComponent<Rigidbody2D>().gravityScale = spaceGravity;
        if (other.gameObject.name == "Player2")
            player2.GetComponent<Rigidbody2D>().gravityScale = spaceGravity;
        if (other.gameObject.name == "Player3")
            player3.GetComponent<Rigidbody2D>().gravityScale = spaceGravity;
        if (other.gameObject.name == "Player4")
            player4.GetComponent<Rigidbody2D>().gravityScale = spaceGravity;
    }
}
