using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public Transform _playerObject;

    private void Start()
    {
        _playerObject = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        gameObject.transform.position = Vector3.MoveTowards(
            gameObject.transform.position, _playerObject.transform.position, 5 * Time.deltaTime);       
    }
}
