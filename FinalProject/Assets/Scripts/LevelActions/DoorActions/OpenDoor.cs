using UnityEngine;

public class OpenDoor : MonoBehaviour
{
	//TODO добавить логику с ключами 
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			Destroy(gameObject);
		}
	}
}
