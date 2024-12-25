using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Settings")]
    public float jumpForce;

    private bool isGrounded = true;

    [Header("References")]
    public Rigidbody2D playerRigidbody;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerRigidbody.AddForceY(jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
        if (!isGrounded && playerRigidbody.linearVelocityY == 0)
        {
            isGrounded = true;
        }
    }

    void onClollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Platform")
        {
            isGrounded = true;
        }
    }
}
