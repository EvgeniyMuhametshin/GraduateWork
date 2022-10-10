using UnityEngine;
using UnityEngine.SceneManagement;

public class StairUpLevelTwo : MonoBehaviour
{
    [SerializeField]
    private PlayerObjects _objects;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _objects.POSITIONS_PLAYER = new Vector3(-18,12,0);
            SceneManager.LoadScene(1);
        }
    }
}
