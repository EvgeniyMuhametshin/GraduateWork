using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public Transform _playerObject;
    private float _speedChase = 3f;

    private void Start()
    {
        _playerObject = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        gameObject.transform.position = Vector3.MoveTowards(
            gameObject.transform.position, _playerObject.transform.position, _speedChase * Time.deltaTime);       
    }
}
