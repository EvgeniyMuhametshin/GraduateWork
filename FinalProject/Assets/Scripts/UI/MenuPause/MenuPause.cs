using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public static bool GameisPaused = false;

    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
		pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
	}

    private void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GameisPaused = true;
    }

    public void ExitStartMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
