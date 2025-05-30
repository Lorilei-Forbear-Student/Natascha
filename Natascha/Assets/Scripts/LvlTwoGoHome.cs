using UnityEngine;

namespace Natascha
{
    public class LvlTwoGoHome : MonoBehaviour
    {
        public Ingredient lvl2Flour;
        public Ingredient lvl2Sugar;
        public Ingredient lvl2Egg;
        public Ingredient lvl2Milk;
        public Ingredient pandan;
        public Ingredient oil;
        public Ingredient frosting;


        private void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.CompareTag("Player") && lvl2Flour == null && lvl2Egg == null && lvl2Sugar == null && lvl2Milk == null && pandan == null && oil == null && frosting == null)
            {
                GameManager.instance.LoadScene("Level 3 Complete");
                Debug.Log("Loading next scene...");
            }
        }
    }
}