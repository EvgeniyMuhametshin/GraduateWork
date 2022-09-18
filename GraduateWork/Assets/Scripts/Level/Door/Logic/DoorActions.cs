using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorActions : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Inventory.Key == 3)
            {
                SceneManager.LoadScene(4);
            }
            Inventory.Key = 0;
        }
    }
}
