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
        _resultKeyDoor = $"{PlayerObjects.COUNT_KEY}";
        _textKeyDoor.text = _resultKeyDoor;

        _resultKeyForPC = $"{PlayerObjects.KEY_FOR_PC}";
        _textKeyForPC.text = _resultKeyForPC;

		_resultCoins = $"{PlayerObjects.COINS}";
		_textCoins.text = _resultCoins;
    }
}
