using UnityEngine;

public class CameraController : MonoBehaviour
{
	[SerializeField]
	private Transform _playerTransform;
	private float _speedCamera = 5f;

	private void Start()
	{
		transform.position = new Vector3()
		{
			x = _playerTransform.position.x,
			y = _playerTransform.position.y,
			z = _playerTransform.position.z - 10,
		};
	}

	private void Update()
    {
		if (_playerTransform)
		{
			Vector3 target = new Vector3()
			{
				x = _playerTransform.position.x,
				y = _playerTransform.position.y,
				z = _playerTransform.position.z - 10,
			};

			Vector3 pos = Vector3.Lerp(transform.position, target,
				_speedCamera * Time.deltaTime);

			transform.position = pos;
		}
	}
}
