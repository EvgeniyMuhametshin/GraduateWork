using UnityEngine;
using UnityEngine.SceneManagement;

public class LoandingNextScene : MonoBehaviour
{
    private int _numberScene;

    public int NumberScene
    {
        get { return _numberScene; }
        set { _numberScene = value; }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(NumberScene);
        }
    }
}
