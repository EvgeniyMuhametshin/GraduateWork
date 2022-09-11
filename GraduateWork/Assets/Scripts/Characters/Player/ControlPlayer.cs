using UnityEngine;

public class ControlPlayer
{
    public void Control(GameObject bodyPlayer, float speed, KeyCode buttonNameForvard, KeyCode buttonNameBack,
		KeyCode buttonNameLeft, KeyCode buttonNameRight)
    {
        if (Input.GetKey(buttonNameForvard))
        {
            bodyPlayer.transform.position = bodyPlayer.transform.position + 
                Vector3.up * speed * Time.deltaTime;
        }
		if (Input.GetKey(buttonNameBack))
		{
			bodyPlayer.transform.position = bodyPlayer.transform.position +
				Vector3.down * speed * Time.deltaTime;
		}
		if (Input.GetKey(buttonNameLeft))
		{
			bodyPlayer.transform.position = bodyPlayer.transform.position +
				Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(buttonNameRight))
		{
			bodyPlayer.transform.position = bodyPlayer.transform.position +
				Vector3.right * speed * Time.deltaTime;
		}
	}
}
