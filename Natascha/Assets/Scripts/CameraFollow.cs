using UnityEngine;

namespace Natascha
{
    public class CameraFollow : MonoBehaviour
    {
        public Transform player;

        void Update()
        {
            transform.position = new Vector3(player.position.x, player.position.y, player.position.z - 10);
            if (player == null)
            {
                Destroy(gameObject);
            }
        }
    }

}