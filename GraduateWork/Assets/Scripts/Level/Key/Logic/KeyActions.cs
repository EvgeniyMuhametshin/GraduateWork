using UnityEngine;

public class KeyActions : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Inventory.Key += 1;
        }
        Debug.Log(Inventory.Key);
        Destroy(gameObject);
    }
}
