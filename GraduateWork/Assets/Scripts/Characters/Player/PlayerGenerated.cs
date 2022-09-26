using UnityEngine;

public class PlayerGenerated : MonoBehaviour
{
    [SerializeField]
    private Sprite _sprite;
	
	[SerializeField]
	private float movingSpeed;
	[SerializeField]
	private Transform playerTransform;//camera

    private float _speedPlayer = 5f;

	#region Button Controller
	[SerializeField]
    private KeyCode _buttonNameForvard = KeyCode.W;
	[SerializeField]
	private KeyCode _buttonNameBack = KeyCode.S;
	[SerializeField]
	private KeyCode _buttonNameLeft = KeyCode.A;
	[SerializeField]
	private KeyCode _buttonNameRight = KeyCode.D;
	#endregion

	private GeneratedCharactersPlayer _generationsCharacter;
    private ControlPlayer _controlPlayer;
    private GameObject _returnGameObject;

	public SavePositions _positions;

	void Start()
    {
        _generationsCharacter = new GeneratedCharactersPlayer();

        _returnGameObject = _generationsCharacter.Generated(new Vector3(1,1,1), 
			_positions.positions, Quaternion.Euler(0,0,0), "Player", 6, _sprite);

        _controlPlayer = new ControlPlayer();
		_returnGameObject.GetComponent<Light>().intensity = 0;

		playerTransform = _returnGameObject.transform;//camera

		transform.position = new Vector3()//camera
		{
			x = playerTransform.position.x,
			y = playerTransform.position.y,
			z = playerTransform.position.z - 10,
		};
	}

    void Update()
    {
        _controlPlayer.Control(_returnGameObject, _speedPlayer, _buttonNameForvard, _buttonNameBack,
			_buttonNameLeft, _buttonNameRight, _returnGameObject.GetComponent<Light>(),
			_returnGameObject.GetComponent<Animator>());

		if (playerTransform)//camera
		{
			Vector3 target = new Vector3()
			{
				x = playerTransform.position.x,
				y = playerTransform.position.y,
				z = playerTransform.position.z - 10,
			};

			Vector3 pos = Vector3.Lerp(transform.position,//camera
				target, movingSpeed * Time.deltaTime);

			transform.position = pos;//camera
		}

		#region Перенести бег в класс контроллер
		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			_speedPlayer = _speedPlayer * 2;
		}
		else if (Input.GetKeyUp(KeyCode.LeftShift))
		{
			_speedPlayer = 5;
		}
		#endregion	
	}
}
