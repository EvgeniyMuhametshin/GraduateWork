using UnityEngine;

public class SoundController : MonoBehaviour
{
	void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.GetComponent<AudioSource>().volume = 0.5f;
        }
        else if (Input.GetKeyUp(KeyCode.W))
		{
			gameObject.GetComponent<AudioSource>().volume = 0;
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			gameObject.GetComponent<AudioSource>().volume = 0.5f;
		}
		else if (Input.GetKeyUp(KeyCode.S))
		{
			gameObject.GetComponent<AudioSource>().volume = 0;
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			gameObject.GetComponent<AudioSource>().volume = 0.5f;
		}
		else if (Input.GetKeyUp(KeyCode.A))
		{
			gameObject.GetComponent<AudioSource>().volume = 0;
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			gameObject.GetComponent<AudioSource>().volume = 0.5f;
		}
		else if (Input.GetKeyUp(KeyCode.D))
		{
			gameObject.GetComponent<AudioSource>().volume = 0;
		}
	}
}
