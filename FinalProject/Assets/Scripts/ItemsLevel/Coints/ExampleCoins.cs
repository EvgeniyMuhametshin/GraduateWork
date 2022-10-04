using UnityEngine;

public class ExampleCoins : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerObjects.coins++;
        }
        Destroy(gameObject);
    }
}
