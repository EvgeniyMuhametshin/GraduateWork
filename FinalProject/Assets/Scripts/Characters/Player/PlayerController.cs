using UnityEngine;

public class PlayerController 
{
    public void Controller(Transform playerBody, KeyCode inputForward, KeyCode inputBack, KeyCode inputLeft,
        KeyCode inputRight, float speedPlayer, SpriteRenderer spriteRendererPlayer)
    {
        if (Input.GetKey(inputForward))
        {
            playerBody.transform.position = playerBody.transform.position + Vector3.up * speedPlayer * Time.deltaTime;
        }
		if (Input.GetKey(inputBack))
		{
			playerBody.transform.position = playerBody.transform.position + Vector3.down * speedPlayer * Time.deltaTime;
		}
		if (Input.GetKey(inputLeft))
		{
			playerBody.transform.position = playerBody.transform.position + Vector3.left * speedPlayer * Time.deltaTime;
			RotationsPlayer(spriteRendererPlayer, true);
		}
		if (Input.GetKey(inputRight))
		{
			playerBody.transform.position = playerBody.transform.position + Vector3.right * speedPlayer * Time.deltaTime;
			RotationsPlayer(spriteRendererPlayer, false);
		}
	}

	private void RotationsPlayer(SpriteRenderer spriteRendererPlayer, bool flipX)
	{
		spriteRendererPlayer.flipX = flipX;
	}
}
