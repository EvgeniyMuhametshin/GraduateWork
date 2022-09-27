using UnityEngine;

public class ExampleKey : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerObjects.countKey++;
        }
        Destroy(gameObject);
    }
}
