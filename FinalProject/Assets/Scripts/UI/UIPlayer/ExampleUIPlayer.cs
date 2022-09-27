using UnityEngine;
using TMPro;

public class ExampleUIPlayer : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _text;

    private string result;

	private void Update()
    {
        result = $"{PlayerObjects.countKey}";
        _text.text = result;
    }
}
