﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public int playerNumber;
    public float aimSpeed = 2;
    public GameObject pappa;

    private string xAim;
    private string yAim;
    private SpriteRenderer rend;

    private void Awake() {
        xAim = "P" + playerNumber + "xAim";
        yAim = "P" + playerNumber + "yAim";
    }

    private void Start() {
        rend = GetComponent<SpriteRenderer>();
    }

    void Update() {

        var h = Input.GetAxis(xAim);
        var v = Input.GetAxis(yAim);

        rend.enabled = false;
        if (!PauseMenu.gameIsPaused && !CountRemainingPlayers.gameIsOver) {
            if (h > 0.5 || h < -0.5 || v > 0.5 || v < -0.5) {
                rend.enabled = true;
            }
        }
        
        

        if (Mathf.Abs(h) > 0.05 || Mathf.Abs(v) > 0.05) {
            var angle = Mathf.Atan2(v, h) * Mathf.Rad2Deg;
            var newRot = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Lerp(transform.rotation, newRot, Time.deltaTime * aimSpeed);
        }

        transform.position = pappa.transform.position;

    }
}