using UnityEngine;
using UnityEngine.SceneManagement;

public class FinaliScene : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitMainMenu()
    {
		SceneManager.LoadScene(0);
	}
}
