using TMPro;
using UnityEngine;

public class Message : MonoBehaviour
{
	[SerializeField]
	private TMP_Text _canvasMessages;

	private void Start()
	{
		_canvasMessages.enabled = false;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			_canvasMessages.enabled = true;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			_canvasMessages.enabled = false;
		}
	}
}