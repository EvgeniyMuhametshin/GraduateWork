using UnityEngine;

public class AudioVerbZone : MonoBehaviour
{
    //TODO Проверить на надобность класса 
    [SerializeField]
    private GameObject _player;
    [SerializeField]
    private GameObject _enemy;

    [SerializeField]
    private AudioSource _backgroundSoundLevel;
	[SerializeField]
	private AudioSource _backgroundSoundEnemy;

	private float _minDistance = 2f;
    private float _maxDistance = 5f;

    private float _distance;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    private void Update()
    {
        _distance = Mathf.Sqrt((_player.transform.position - _enemy.transform.position).sqrMagnitude);
        Debug.Log(_distance);

        if (_distance > _maxDistance)
        {
            _backgroundSoundLevel.volume = 0f;//вынести значение как минимальное значение звука
            _backgroundSoundEnemy.volume = 0.1f;//вынести значение как минимальное значение звука
            _backgroundSoundEnemy.Play();
		}
    }
}