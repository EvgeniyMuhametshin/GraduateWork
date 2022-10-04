using UnityEngine;

public class KeyForPC : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerObjects.keyForPC++;
        }
        Destroy(gameObject);
    }
}
