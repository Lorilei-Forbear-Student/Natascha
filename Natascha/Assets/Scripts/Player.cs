using UnityEngine;

namespace Natascha
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Player : MonoBehaviour
    {
        [SerializeField] public Rigidbody2D rb;
        [SerializeField] private Transform groundCheck;
        [SerializeField] private LayerMask groundLayer;

        public float horizontal;
        public float speed = 8f;
        public float jumpPower = 16f;
        public bool isFacingRight = true;


        void Update()
        {
            horizontal = Input.GetAxisRaw("Horizontal");

            if (Input.GetButtonDown("Jump") && IsGrounded())
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            }

            if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
            {
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
            }
            Flip();
        }

        private void FixedUpdate()
        {
            rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        }

        private bool IsGrounded()
        {
            return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
        }

        private void Flip()
        {
            if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
            {
                isFacingRight = !isFacingRight;
                Vector3 localScale = transform.localScale;
                localScale.x *= -1f;
                transform.localScale = localScale;
            }
        }
    }

}