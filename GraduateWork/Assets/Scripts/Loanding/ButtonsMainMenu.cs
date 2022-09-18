using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsMainMenu : MonoBehaviour
{
    public void LoadSceneOne()
    {
        SceneManager.LoadScene(1);
        Inventory.Key = 0;
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
