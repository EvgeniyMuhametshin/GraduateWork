using UnityEngine;

public class CameraController : MonoBehaviour
{
	[SerializeField]
	private Transform _playerTransform;
	private float _speedCamera = 0.025f;

	private void Start()
	{
		_playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
	}

	private void Update()
    {
		transform.position = Vector3.Lerp(transform.position, 
			_playerTransform.transform.position + new Vector3(0,0,-10), _speedCamera);
	}
}
