using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

namespace Natascha
{
    public class ToggleChecks : MonoBehaviour
    {
        public Ingredient flour;
        public Ingredient egg;
        public Ingredient sugar;
        public Ingredient pecans;
        public Ingredient butter;

        public Image flourCheckMark;
        public Image eggCheckMark;
        public Image sugarCheckMark;
        public Image butterCheckMark;
        public Image pecansCheckMark;

        private void Update()
        {
            if (flour != null)
            {
                flourCheckMark.gameObject.SetActive(false);
            }
            else
            {
                flourCheckMark.gameObject.SetActive(true);
            }

            if(egg != null)
            {
                eggCheckMark.gameObject.SetActive(false);
            }
            else
            {
                eggCheckMark.gameObject.SetActive(true);
            }

            if (sugar != null)
            {
                sugarCheckMark.gameObject.SetActive(false);
            }
            else
            {
                sugarCheckMark.gameObject.SetActive(true);
            }

            if(pecans != null)
            {
                pecansCheckMark.gameObject.SetActive(false);
            }
            else
            {
                pecansCheckMark.gameObject.SetActive(true);
            }

            if(butter != null)
            {
                butterCheckMark.gameObject.SetActive(false);
            }
            else
            {
                butterCheckMark.gameObject.SetActive(true);
            }
        }
    }
}