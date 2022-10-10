using UnityEngine;
using UnityEngine.SceneManagement;

public class ExamplePlayer : MonoBehaviour
{
    [SerializeField]
    private Transform _playerBody;
    [SerializeField]
    private SpriteRenderer _playerRenderer;
    [SerializeField]
    private float _speedPlayer = 5;

    [SerializeField]
    private Animator _animatorPlayer;
    [SerializeField]
    private AudioSource _audioPlayer;

    private PlayerController _controllerPlayer;

	#region Key Code
	[SerializeField]
    private KeyCode _inputForward = KeyCode.W;
	[SerializeField]
	private KeyCode _inputBack = KeyCode.S;
	[SerializeField]
	private KeyCode _inputLeft = KeyCode.A;
	[SerializeField]
	private KeyCode _inputRight = KeyCode.D;
	#endregion

	private int _health = 100;

	private void Start()
    {
        _controllerPlayer = new PlayerController();

        PlayerObjects.HEALTH_POINTS = _health;
    }

    private void Update()
    {
        _controllerPlayer.Controller(_playerBody, _inputForward, _inputBack, 
            _inputLeft, _inputRight, _speedPlayer, _playerRenderer, _animatorPlayer, 
            _audioPlayer);

        DestroyPlayer(PlayerObjects.HEALTH_POINTS);
    }

    private void DestroyPlayer(int healthPoint)
    {
        if (healthPoint <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(4);
        }
    }
}
