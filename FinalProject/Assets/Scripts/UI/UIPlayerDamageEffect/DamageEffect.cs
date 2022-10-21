using UnityEngine;
using UnityEngine.UI;

public class DamageEffect : MonoBehaviour
{
    [SerializeField]
    private Image _image;

    private void Start()
    {
        PlayerObjects.COLOR_ALTHA.a = 0;
        _image.color = PlayerObjects.COLOR_ALTHA;
    }

    private void Update()
    {
        _image.color = PlayerObjects.COLOR_ALTHA;
    }
}
