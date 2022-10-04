using UnityEngine;

public class EnemyFlags : MonoBehaviour
{
	[SerializeField]
	private Transform _playerObject;
	[SerializeField]
	private Animator _animator;

	private float _distance;
	private float _minDistance = 5f;

	private void Start()
	{
		_playerObject = GameObject.FindGameObjectWithTag("Player").transform;
	}

	private void Update()
    {
		_distance = Mathf.Sqrt((gameObject.transform.position - 
			_playerObject.transform.position).sqrMagnitude);

		if (_distance < _minDistance)
		{
			gameObject.GetComponent<EnemyChase>().enabled = true;
			gameObject.GetComponent<ExampleEnemy>().enabled = false;
			_animator.SetBool("WalkEnemy", true);
		}
		else
		{
			_animator.SetBool("WalkEnemy", false);
		}
		if (_distance > _minDistance)//необязательное сравнение 
		{
			gameObject.GetComponent<EnemyChase>().enabled = false;
			gameObject.GetComponent<ExampleEnemy>().enabled = true;
		}
	}
}
