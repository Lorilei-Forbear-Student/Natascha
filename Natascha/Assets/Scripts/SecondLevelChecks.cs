using UnityEngine;
using UnityEngine.UI;

namespace Natascha
{
    public class SecondLevelChecks : MonoBehaviour
    {
        public Ingredient IngredientSix;
        public Ingredient IngredientSeven;

        public Image checkMarkSix;
        public Image checkMarkSeven;

        void Update()
        {
            if (IngredientSix != null)
            {
                checkMarkSix.gameObject.SetActive(false);
            }
            else
            {
                checkMarkSix.gameObject.SetActive(true);
            }

            if (IngredientSeven != null)
            {
                checkMarkSeven.gameObject.SetActive(false);
            }
            else
            {
                checkMarkSeven.gameObject.SetActive(true);
            }
        }
    }
}