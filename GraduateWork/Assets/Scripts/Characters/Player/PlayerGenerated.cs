using UnityEngine;

public class PlayerGenerated : MonoBehaviour
{
    [SerializeField]
    private Sprite _sprite;

    [SerializeField] 
    private Camera _camera;

    private const float _speedPlayer = 5f;

    [SerializeField]
    private KeyCode _buttonNameForvard = KeyCode.W;
	[SerializeField]
	private KeyCode _buttonNameBack = KeyCode.S;
	[SerializeField]
	private KeyCode _buttonNameLeft = KeyCode.A;
	[SerializeField]
	private KeyCode _buttonNameRight = KeyCode.D;

	private GeneratedCharacters _generationsCharacter;
    private ControlPlayer _controlPlayer;
    private GameObject _returnGameObject;

	void Start()
    {
        _generationsCharacter = new GeneratedCharacters();

        _returnGameObject = _generationsCharacter.Generated(new Vector3(1,1,1), new Vector3(0,0,0),
            Quaternion.Euler(0,0,0), "Player", 6, _sprite);

        _controlPlayer = new ControlPlayer();
    }

    void Update()
    {
        _controlPlayer.Control(_returnGameObject, _speedPlayer, _buttonNameForvard, _buttonNameBack,
			_buttonNameLeft, _buttonNameRight);

        _camera.transform.position = _returnGameObject.transform.position + new Vector3(0,0,-5);
	}
}
