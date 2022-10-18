using UnityEngine;

public class OpenDoor : MonoBehaviour
{
	[SerializeField]
	private Animator _animator;

	private void Start()
	{
		_animator = GetComponent<Animator>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player") && PlayerObjects.COUNT_KEY >= 2)
		{
			_animator.SetBool("OpenDoorAnim", true);
		}
	}
}
