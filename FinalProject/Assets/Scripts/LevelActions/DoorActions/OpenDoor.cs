using UnityEngine;

public class OpenDoor : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player") && PlayerObjects.COUNT_KEY >= 2)
		{
			Destroy(gameObject);
		}
		else
		{
			Debug.LogWarning("You are needed the 2 keys");
		}
	}
}
