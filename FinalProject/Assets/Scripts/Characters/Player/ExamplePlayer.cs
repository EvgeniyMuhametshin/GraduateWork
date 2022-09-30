using UnityEngine;

public class ExamplePlayer : MonoBehaviour
{
    [SerializeField]
    private Transform _playerBody;
    [SerializeField]
    private SpriteRenderer _playerRenderer;
    [SerializeField]
    private Camera _cameraPlayer;
    [SerializeField]
    private float _speedPlayer = 5;

    [SerializeField]
    private Animator _animatorPlayer;

    private PlayerController _controllerPlayer;
    private CameraController _cameraController;

    [SerializeField]
    private KeyCode _inputForward = KeyCode.W;
	[SerializeField]
	private KeyCode _inputBack = KeyCode.S;
	[SerializeField]
	private KeyCode _inputLeft = KeyCode.A;
	[SerializeField]
	private KeyCode _inputRight = KeyCode.D;

	private void Start()
    {
        _controllerPlayer = new PlayerController();
        _cameraController = new CameraController();
    }

    private void Update()
    {
        _controllerPlayer.Controller(_playerBody, _inputForward, _inputBack, 
            _inputLeft, _inputRight, _speedPlayer, _playerRenderer, _animatorPlayer);
        _cameraController.Controller(_playerBody, _cameraPlayer);
    }
}
