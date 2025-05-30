using UnityEngine;

namespace Natascha
{
    public class ProjectileBehaviour : MonoBehaviour
    {
        public Rigidbody2D projectilePrefab;
        public float projectileSpeed = 800f;
        public Player player;
        private float fireRate = 0.2f;
        private float nextFire;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E) && Time.time > nextFire)
            {
                Fire();
                nextFire = Time.time + fireRate;
            }
        }

        private void Fire()
        {
            if (player.isFacingRight.Equals(false) && -player.rb.velocity.x == 0)
            {
                Quaternion rotation = Quaternion.Euler(0, 180, 0);
                Rigidbody2D bullet = Instantiate(projectilePrefab, transform.position, rotation);
                bullet.GetComponent<Rigidbody2D>().AddForce(-transform.right * projectileSpeed);
            }
            else if (player.rb.velocity.x == 0)
            {
                Rigidbody2D bullet = Instantiate(projectilePrefab, transform.position, transform.rotation);
                bullet.GetComponent<Rigidbody2D>().AddForce(transform.right * projectileSpeed);
            }
        }
    }
}