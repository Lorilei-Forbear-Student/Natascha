using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Natascha
{
    public class ToggleUI : MonoBehaviour
    {
        public Player player;
        private bool menuOn = false;
        private bool mapOn = false;
        public GameObject menu;
        public GameObject map;
        public GameObject hearts;
        private void Start()
        {
            menu.SetActive(false);
            map.SetActive(false);
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                menuOn = !menuOn;
                if (menuOn == true)
                {
                    menu.SetActive(true);
                }
                else
                {
                    menu.SetActive(false);
                }
            }

            if (Input.GetKeyDown(KeyCode.M))
            {
                mapOn = !mapOn;
                if (mapOn == true)
                {
                    map.SetActive(true);
                }
                else
                {
                    map.SetActive(false);
                }

            }

            if(menuOn == true || mapOn == true)
            {
                Time.timeScale = 0;
                hearts.SetActive(false);

            }
            else
            {
                Time.timeScale = 1;
                hearts.SetActive(true);
            }

        }
    }
}
