using UnityEngine;
using TMPro;

public class ExampleUIPlayer : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _textKeyDoor;
    [SerializeField]
    private TMP_Text _textKeyForPC;
	[SerializeField]
	private TMP_Text _textCoins;

	private string _resultKeyDoor;
    private string _resultKeyForPC;
    private string _resultCoins;

	private void Update()
    {
        _resultKeyDoor = $"{PlayerObjects.countKey}";
        _textKeyDoor.text = _resultKeyDoor;

        _resultKeyForPC = $"{PlayerObjects.keyForPC}";
        _textKeyForPC.text = _resultKeyForPC;

		_resultCoins = $"{PlayerObjects.coins}";
		_textCoins.text = _resultCoins;
	}
}
