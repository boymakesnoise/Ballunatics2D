using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killed : MonoBehaviour
{
    //private GameObject pil;
    //private Jump jumpScript;

    void OnTriggerEnter2D(Collider2D other) {

        Debug.Log("Collision Detected");
        
        if (other.gameObject.name == "Killbox") {
            /*
            jumpScript = GetComponent<Jump>();
            //pil = GetComponent<>

            pil = jumpScript.sikte;
            //Destroy
            */
            Destroy(this.gameObject);
        }
    }
}
