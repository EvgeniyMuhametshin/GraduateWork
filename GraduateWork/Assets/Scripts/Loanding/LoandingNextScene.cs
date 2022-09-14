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

	public Vector3 _position;
    public SavePositions _playerPositions;  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _playerPositions.positions = _position;
            SceneManager.LoadScene(NumberScene);
        }
    }
}
