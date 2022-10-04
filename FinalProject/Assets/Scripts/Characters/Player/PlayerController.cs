using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController 
{
    public void Controller(Transform playerBody, KeyCode inputForward, KeyCode inputBack, KeyCode inputLeft,
        KeyCode inputRight, float speedPlayer, SpriteRenderer spriteRendererPlayer, Animator animator, AudioSource audioSource)
    {
        if (Input.GetKey(inputForward))
        {
            playerBody.transform.position = playerBody.transform.position + Vector3.up * speedPlayer * Time.deltaTime;
			animator.SetBool("WalkPlayer", true);
			audioSource.Play();
		}
		else
		{
			audioSource.Pause();
			animator.SetBool("WalkPlayer", false);
		}
		if (Input.GetKey(inputBack))
		{
			playerBody.transform.position = playerBody.transform.position + Vector3.down * speedPlayer * Time.deltaTime;
			animator.SetBool("WalkPlayer", true);
			audioSource.Play();
		}
		if (Input.GetKey(inputLeft))
		{
			playerBody.transform.position = playerBody.transform.position + Vector3.left * speedPlayer * Time.deltaTime;
			RotationsPlayer(spriteRendererPlayer, true);
			animator.SetBool("WalkPlayer", true);
			audioSource.Play();
		}
		if (Input.GetKey(inputRight))
		{
			playerBody.transform.position = playerBody.transform.position + Vector3.right * speedPlayer * Time.deltaTime;
			RotationsPlayer(spriteRendererPlayer, false);
			animator.SetBool("WalkPlayer", true);
			audioSource.Play();
		}
	}

	private void RotationsPlayer(SpriteRenderer spriteRendererPlayer, bool flipX)
	{
		spriteRendererPlayer.flipX = flipX;
	}
}
