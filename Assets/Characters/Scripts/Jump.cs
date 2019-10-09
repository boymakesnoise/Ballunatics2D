using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public int playerNumber;
    public GameObject sikte;
    public float jumpSpeed = 10f;
    public float raycastStartOffset = 0.55f;
    public float raycastLength = 0.2f;
    public float scootchForce;

    private string jumpButton;
    private float distToGround;
    private bool canJump = true;
    private Vector3 m_NewForce;
    private Rigidbody2D m_Rigidbody;
    private Collider2D m_Collider;
    private string xAim;

    private int jumps = 0;
    private bool canLand = true;
    private string jumpingPlayer;

    private void Awake() {
        xAim = "P" + playerNumber + "xAim";
    }

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        m_Collider = GetComponent<Collider2D>();

        // get the distance to ground
        distToGround = m_Collider.bounds.extents.y;

        jumpButton = "P" + playerNumber + "jump";
    }

    private void Update() {

        // Jump
        if (Input.GetAxisRaw(jumpButton) >= 0.5f && canJump) {
            m_NewForce = sikte.transform.right;
            if (jumps > 0) {
                canJump = false;
                jumps--;
                canLand = true;

                if (!IsGrounded()) {
                    m_Rigidbody.velocity = new Vector2(0, 0); //NOLLSTÄLLER HASTIGHET
                }

                m_Rigidbody.AddForce(m_NewForce * jumpSpeed, ForceMode2D.Impulse);

                jumpingPlayer = "JumpP" + playerNumber;
                FindObjectOfType<AudioManager>().Play(jumpingPlayer);
            }
        }

        Debug.DrawRay(transform.position + new Vector3(0, -raycastStartOffset, 0), -Vector2.up * raycastLength, Color.yellow);
        //Debug.Log(jumps);

        if (Input.GetAxisRaw(jumpButton) < 0.5f) {
            canJump = true;
        }

        // Scootching
        if (IsGrounded()) {
            var h = Input.GetAxis(xAim);
            m_Rigidbody.AddForce(new Vector2(h * scootchForce, 0));
        }

        if (IsGrounded() && canLand) {
            canLand = false;
            jumps = 1;
        }
    }

    // Ground Check
    private bool IsGrounded() {
        return Physics2D.Raycast(transform.position + new Vector3(0, -raycastStartOffset, 0), -Vector2.up, raycastLength);
    }

}
