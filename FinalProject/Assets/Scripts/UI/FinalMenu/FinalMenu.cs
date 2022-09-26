using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalMenu : MonoBehaviour
{
	[SerializeField]
	private PlayerObjects _objects;

	public void Restart()
    {
        SceneManager.LoadScene(1);
		_objects.positionsPlayer = new Vector3(0, -10, 0);
	}

    public void ExitStartMenu()
    {
        SceneManager.LoadScene(0);
    }
}
