using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Player player;

    private string horizontalAxis;
    private string verticalAxis;
    private string aButton;
    private string bButton;
    private string triggerAxis;
    private int controllerNumber;

    //public float Horizontal { get; set }
    //public float Thrust { get; set }

    internal void SetControllerNumber(int number) {
        controllerNumber = number;
        horizontalAxis = "J" + controllerNumber + "Horizontal";
        verticalAxis = "J" + controllerNumber + "Vertical";
        aButton = "J" + controllerNumber + "A";
        triggerAxis = "J" + controllerNumber + "Trigger";
    }

    private void Awake() {
        player = GetComponent<Player>();
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
