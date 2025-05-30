using UnityEngine;

namespace Natascha
{
    public class GoHomeLevelZero : MonoBehaviour
    {
        public Ingredient flourLevel0;
        public Ingredient yeast;
        public Ingredient water;
        public Ingredient salt;

        private void OnTriggerEnter2D(Collider2D collider)
        {
            if(collider.CompareTag("Player") && flourLevel0 == null &&  yeast == null && water == null && salt == null)
            {
                GameManager.instance.LoadScene("Level 1 Complete");
                Debug.Log("Loading next level...");
            }
        }
    }
}
