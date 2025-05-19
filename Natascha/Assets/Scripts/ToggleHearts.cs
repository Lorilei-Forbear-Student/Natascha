using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace Natascha
{
    public class ToggleHearts : MonoBehaviour
    {
        public Health health;

        public RawImage heartOne;
        public RawImage heartTwo;
        public RawImage heartThree;
        public RawImage heartFour;
        public RawImage heartFive;

        private void Update()
        {
            if(health.currentHealth < 5)
            {
                heartFive.gameObject.SetActive(false);
            }
            if(health.currentHealth < 4)
            {
                heartFour.gameObject.SetActive(false);
            }
            if(health.currentHealth < 3)
            {
                heartThree.gameObject.SetActive(false);
            }
            if (health.currentHealth < 2)
            {
                heartTwo.gameObject.SetActive(false);
            }
        }
    }
}
