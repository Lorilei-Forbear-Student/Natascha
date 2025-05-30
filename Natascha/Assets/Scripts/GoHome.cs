using Unity.VisualScripting;
using UnityEngine;

namespace Natascha
{
    public class GoHome : MonoBehaviour
    {
        public Ingredient flour;
        public Ingredient egg;
        public Ingredient sugar;
        public Ingredient pecans;
        public Ingredient butter;

        private void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.CompareTag("Player") && flour == null && egg == null && sugar == null && pecans == null && butter == null)
            {
                    GameManager.instance.LoadScene("Level 2 Complete");
                    Debug.Log("Loading next scene...");
            }
        }
    }
}