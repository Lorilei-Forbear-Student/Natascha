using UnityEngine;

namespace Natascha
{
    [RequireComponent(typeof(Collider2D))]
    public class Ingredient : MonoBehaviour
    {
        public GameObject self;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Destroy(self);
            }
        }
    }
}
