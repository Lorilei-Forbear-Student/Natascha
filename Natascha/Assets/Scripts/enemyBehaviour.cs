using Unity.VisualScripting;
using UnityEngine;

namespace Natascha
{
    public class EnemyBehaviour : MonoBehaviour
    {
        private float speed = 1f;
        [SerializeField] private Transform target;
        private bool withinRange = false;
        [SerializeField] private Transform groundCheck;
        [SerializeField] private LayerMask groundLayer;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            withinRange = true;
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            withinRange = false;
        }
        private bool IsGrounded()
        {
            if (groundCheck == null)
            {
                Destroy(groundCheck);
                return false;
            }
            else return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
        }
        private void Update()
        {
            float step = speed * Time.deltaTime;
            if (withinRange == true && IsGrounded() == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            }
        }
    }
}
