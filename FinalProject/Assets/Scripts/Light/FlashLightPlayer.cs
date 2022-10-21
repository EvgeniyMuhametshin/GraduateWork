using UnityEngine;

public class FlashLightPlayer : MonoBehaviour
{
    [SerializeField]
    private Light _light;

    private void Start()
    {
        _light.intensity = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            _light.intensity = 3f;
        }
        else if(Input.GetKeyUp(KeyCode.L))
        {
            _light.intensity = 0;
        }
    }
}
