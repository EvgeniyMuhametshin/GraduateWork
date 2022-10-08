using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    [SerializeField]
    private static bool GameisPaused = false;
    [SerializeField]
    private AudioSource _audioSource;

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
        _audioSource.Play();
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
        _audioSource.Play();
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
