using UnityEngine;

public class EnemyFlags : MonoBehaviour
{
	[SerializeField]
	private Transform _playerObject;

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
            gameObject.GetComponent<EnemyLook>().enabled = true;
			gameObject.GetComponent<ExampleEnemy>().enabled = false;
		}
		if (_distance > _minDistance)//необязательное сравнение 
		{
			gameObject.GetComponent<EnemyLook>().enabled = false;
			gameObject.GetComponent<ExampleEnemy>().enabled = true;
		}
	}
}
