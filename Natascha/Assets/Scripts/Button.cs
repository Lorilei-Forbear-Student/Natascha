using UnityEngine;
using UnityEngine.SceneManagement;

namespace Natascha
{
    public class Button : MonoBehaviour
    {
        public void TryAgain()
        {
            GameManager.instance.LoadScene("LevelSelect");
            Debug.Log("Level Select Loaded");
        }

        public void LoadLevelOne()
        {
            GameManager.instance.LoadScene("Level 1");
            Debug.Log("Level 1 Loaded");
        }

        public void LoadLevelTwo()
        {
            GameManager.instance.LoadScene("Level 2");
            Debug.Log("Level 2 Loaded");
        }

        public void LoadLevelThree()
        {
            GameManager.instance.LoadScene("Level 3");
            Debug.Log("Level 3 Loaded");
        }
        public void Quit()
        {
            Debug.Log("Quitting...");
            Application.Quit();
        }

        public void GameOver()
        {
            GameManager.instance.LoadScene("Game Completed");
        }
    }
}
