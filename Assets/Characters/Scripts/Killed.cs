using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killed : MonoBehaviour
{
    public GameObject pil;

    void OnTriggerEnter2D(Collider2D other) {
        
        if (other.gameObject.name == "Killbox") {

            Destroy(pil);
            Destroy(this.gameObject);

        }
    }
}
