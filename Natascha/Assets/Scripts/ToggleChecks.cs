using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

namespace Natascha
{
    public class ToggleChecks : MonoBehaviour
    {
        public Ingredient ingredientOne;
        public Ingredient ingredientTwo;
        public Ingredient ingredientThree;
        public Ingredient ingredientFour;
        public Ingredient ingredientFive;

        public Image checkMarkOne;
        public Image checkMarkTwo;
        public Image checkMarkThree;
        public Image checkMarkFour;
        public Image checkMarkFive;

        private void Update()
        {
            if (ingredientOne != null)
            {
                checkMarkOne.gameObject.SetActive(false);
            }
            else
            {
                checkMarkOne.gameObject.SetActive(true);
            }

            if(ingredientTwo != null)
            {
                checkMarkTwo.gameObject.SetActive(false);
            }
            else
            {
                checkMarkTwo.gameObject.SetActive(true);
            }

            if (ingredientThree != null)
            {
                checkMarkThree.gameObject.SetActive(false);
            }
            else
            {
                checkMarkThree.gameObject.SetActive(true);
            }

            if(ingredientFour != null)
            {
                checkMarkFour.gameObject.SetActive(false);
            }
            else
            {
                checkMarkFour.gameObject.SetActive(true);
            }

            if(ingredientFive != null)
            {
                checkMarkFive.gameObject.SetActive(false);
            }
            else
            {
                checkMarkFive.gameObject.SetActive(true);
            }
        }
    }
}