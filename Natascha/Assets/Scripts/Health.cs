using UnityEngine;

namespace Natascha
{
    public class Health : MonoBehaviour
    {
        public int currentHealth;
        private int maxHealth = 5;
        public int damage;
        void Start()
        {
            currentHealth = maxHealth;
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Damage") && currentHealth > 0)
            {
                currentHealth--;
            }
            else if(other.CompareTag("DamageTeleport"))
            {
                currentHealth--;
                transform.position = new Vector3(-7, - 2.55f, 0);
            }
            if (currentHealth <= 0)
            {
                GameManager.instance.LoadScene("Game Over");
            }
        }
    }
}
