using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Settings")]
    public float JumpForce;

    private bool _isGrounded = true;

    [Header("References")]
    public Rigidbody2D PlayerRigidbody;

    public Animator PlayerAnimator;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            PlayerRigidbody.AddForceY(JumpForce, ForceMode2D.Impulse);
            _isGrounded = false;
        }
        if (!_isGrounded && PlayerRigidbody.linearVelocityY == 0)
        {
            _isGrounded = true;
        }
    }

    void onClollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Platform")
        {
            _isGrounded = true;
        }
    }
}
