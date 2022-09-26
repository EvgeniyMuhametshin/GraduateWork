using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField]
    private PlayerObjects _objects;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        _objects.positionsPlayer = new Vector3(0, -10, 0);
    }

    public void ExitGame()
    {
        Debug.Log("Game Exit");
        Application.Quit();
    }
}
