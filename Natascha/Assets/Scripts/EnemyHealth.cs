using System.Transactions;
using UnityEngine;

namespace Natascha
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(Animator))]
    public class EnemyHealth : MonoBehaviour
    {
        public float currentEnemyHealth;
        private float enemyMaxHealth = 3;
        public float damage;

        void Start()
        {
            currentEnemyHealth = enemyMaxHealth;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.gameObject.CompareTag("Projectile") && currentEnemyHealth > 0)
            {
                currentEnemyHealth -= damage;
            }

            if (currentEnemyHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
     }
}
