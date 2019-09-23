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
    private bool canDoublejump = false;
    private bool canJump = true;
    private Vector3 m_NewForce;
    private Rigidbody2D m_Rigidbody;
    private Collider2D m_Collider;
    private string xAim;

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

        if (Input.GetAxisRaw(jumpButton) >= 0.5f && canJump) {
            m_NewForce = sikte.transform.right;
            if (IsGrounded()) {
                canJump = false;
                m_Rigidbody.velocity = new Vector2(0, 0); //NOLLSTÄLLER HASTIGHET
                m_Rigidbody.AddForce(m_NewForce * jumpSpeed, ForceMode2D.Impulse);
                canDoublejump = true;
            }
            else {
                if (canDoublejump) {
                    m_Rigidbody.velocity = new Vector2(0, 0);
                    m_Rigidbody.AddForce(m_NewForce * jumpSpeed, ForceMode2D.Impulse);
                    canDoublejump = false;
                }
            }
        }

        //Debug.DrawRay(transform.position, -Vector2.up * distToGround, Color.green);
        Debug.DrawRay(transform.position + new Vector3(0, -raycastStartOffset, 0), -Vector2.up * raycastLength, Color.yellow);
        //Debug.Log(canDoublejump);

        if (Input.GetAxisRaw(jumpButton) < 0.5f) {
            canJump = true;
        }

        // Scootching
        if (IsGrounded()) {
            var h = Input.GetAxis(xAim);
            m_Rigidbody.AddForce(new Vector2(h * scootchForce, 0));
        }

    }

    // Ground Check
    private bool IsGrounded() {
        //return Physics2D.Raycast(transform.position, -Vector2.up, distToGround + 0.1f);
        return Physics2D.Raycast(transform.position + new Vector3(0, -raycastStartOffset, 0), -Vector2.up, raycastLength);
    }
}
