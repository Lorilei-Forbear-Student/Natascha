using UnityEngine;
using UnityEngine.UI;

namespace Natascha
{
    public class ToggleCheckLevelZero : MonoBehaviour
    {
        public Ingredient lvl0Flour;
        public Ingredient yeast;
        public Ingredient water;
        public Ingredient salt;

        public Image flourCheck;
        public Image yeastCheck;
        public Image waterCheck;
        public Image saltCheck;

        void Update()
        {
            if (lvl0Flour != null)
            {
                flourCheck.gameObject.SetActive(false);
            }
            else
            {
                flourCheck.gameObject.SetActive(true);
            }

            if (yeast != null)
            {
                yeastCheck.gameObject.SetActive(false);
            }
            else
            {
                yeastCheck.gameObject.SetActive(true);
            }

            if (water != null)
            {
                waterCheck.gameObject.SetActive(false);
            }
            else
            {
                waterCheck.gameObject.SetActive(true);
            }

            if (salt != null)
            {
                saltCheck.gameObject.SetActive(false);
            }
            else
            {
                saltCheck.gameObject.SetActive(true);
            }
        }
    }
}
