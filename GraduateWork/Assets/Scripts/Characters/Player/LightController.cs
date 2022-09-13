using UnityEngine;

public class LightController : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<Light>().intensity = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
			gameObject.GetComponent<Light>().intensity = 1;
		}
        else if (Input.GetKeyUp(KeyCode.F))
		{
			gameObject.GetComponent<Light>().intensity = 0;
		}
    }
}
