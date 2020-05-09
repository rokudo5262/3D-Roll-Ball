using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
        public void Resume()
        {
            Time.timeScale=1f;
        }
        public void Pause()
        {
            Time.timeScale=0f;
        }
        public void BackToMenu()
        {
            SceneManager.LoadScene(0);
        }
        public void Reset()
        {
            SceneManager.LoadScene(1);
        }
        public void ResetTutorial()
        {
            SceneManager.LoadScene(2);
        }
}
