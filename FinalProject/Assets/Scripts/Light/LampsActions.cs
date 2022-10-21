using UnityEngine;

public class LampsActions : MonoBehaviour
{
	[SerializeField]
	private Light _light;
	[SerializeField]
	private float startWaitTime = 10;

	private float waitTime;

	private void Start()
	{
		_light.intensity = 18;
	}

	private void Update()
	{
		if (waitTime <= 0)
		{
			_light.intensity = 10;
			waitTime = startWaitTime;
		}
		else
		{
			_light.intensity -= Time.deltaTime;
			waitTime -= Time.deltaTime;
		}
	}
}
