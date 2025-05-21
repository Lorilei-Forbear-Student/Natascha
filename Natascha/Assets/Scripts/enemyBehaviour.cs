using UnityEngine;

namespace Natascha
{
    public class enemyBehaviour : MonoBehaviour
    {
        public Transform player;
        private float speed = 2f;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player") == true)
            {
                //Vector2.MoveTowards(
            }
        }
    }
}
