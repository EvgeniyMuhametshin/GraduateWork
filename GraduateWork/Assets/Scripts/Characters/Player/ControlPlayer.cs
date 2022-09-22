using UnityEngine;

public class ControlPlayer
{
    public void Control(GameObject bodyPlayer, float speed, KeyCode buttonNameForvard, KeyCode buttonNameBack,
		KeyCode buttonNameLeft, KeyCode buttonNameRight, Light light, Animator animator)
    {
		if (Input.GetKey(buttonNameForvard))
		{
			bodyPlayer.transform.position = bodyPlayer.transform.position +
				Vector3.up * speed * Time.deltaTime;
			animator.SetBool("MoveUp", true);
		}
		else 
		{
			animator.SetBool("MoveUp", false);
		}
		if (Input.GetKey(buttonNameBack))
		{
			bodyPlayer.transform.position = bodyPlayer.transform.position +
				Vector3.down * speed * Time.deltaTime;
			animator.SetBool("MoveDown", true);
		}
		else
		{
			animator.SetBool("MoveDown", false);
		}
		if (Input.GetKey(buttonNameLeft))
		{
			bodyPlayer.transform.position = bodyPlayer.transform.position +
				Vector3.left * speed * Time.deltaTime;
			animator.SetBool("MoveLeft", true);
		}
		else
		{
			animator.SetBool("MoveLeft", false);
		}
		if (Input.GetKey(buttonNameRight))
		{
			bodyPlayer.transform.position = bodyPlayer.transform.position +
				Vector3.right * speed * Time.deltaTime;
			animator.SetBool("MoveRight", true);
		}
		else
		{
			animator.SetBool("MoveRight", false);
		}

		#region Light
		if (Input.GetKeyDown(KeyCode.F))
		{
			bodyPlayer.GetComponent<Light>().intensity = 1;
		}
		else if (Input.GetKeyUp(KeyCode.F))
		{
			bodyPlayer.GetComponent<Light>().intensity = 0;
		}
		#endregion
	}
}