using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorActions : MonoBehaviour
{
    [SerializeField]
    private Inventory _inventory;

    private void Start()
    {
        _inventory = (Inventory)Resources.Load("ScriptableObjects/Inventory");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (_inventory.Key == 3)
            {
                SceneManager.LoadScene(4);
            }
        }
    }
}
