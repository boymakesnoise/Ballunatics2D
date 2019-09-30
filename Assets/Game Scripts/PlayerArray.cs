using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArray : MonoBehaviour
{

    public static List<int> activePlayers = new List<int>();

    void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update() {

        foreach (var item in activePlayers) {
            //Debug.Log(item);
        }

    }

    // lägg in kod för att förstöra detta gameobject när går tillbaka till main menu

}
