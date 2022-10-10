using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField]
    private PlayerObjects _objects;

    [SerializeField]
    private AudioSource _audioSource;

    public void StartGame()
    {
        _audioSource.Play();
        SceneManager.LoadScene(1);
        _objects.POSITIONS_PLAYER = new Vector3(0, -10, 0);
    }

    public void ExitGame()
    {
		_audioSource.Play();
		Application.Quit();
    }
}
