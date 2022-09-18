using TMPro;
using UnityEngine;

public class UIPlayer : MonoBehaviour
{
    [SerializeField]
    public TMP_Text _text;

    private string _countKey;

    private void Update()
    {
		_countKey = $"{Inventory.Key}";
		_text.text = _countKey;
    }
}
