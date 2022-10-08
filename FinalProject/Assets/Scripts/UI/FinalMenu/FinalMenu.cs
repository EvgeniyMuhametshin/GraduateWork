using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalMenu : MonoBehaviour
{
	[SerializeField]
	private PlayerObjects _objects;

    [SerializeField]
    private AudioSource _audioSource;

	public void Restart()
    {
        _audioSource.Play();
        SceneManager.LoadScene(1);
		_objects.positionsPlayer = new Vector3(0, -10, 0);
	}

    public void ExitStartMenu()
    {
        _audioSource.Play();
        SceneManager.LoadScene(0);
    }
}
