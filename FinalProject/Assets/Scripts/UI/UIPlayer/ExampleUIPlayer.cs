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
    [SerializeField]
    private TMP_Text _textHealthPlayer;

	private string _resultKeyDoor;
    private string _resultKeyForPC;
    private string _resultCoins;
    private string _resultHealthPlayer;

	private void Update()
    {
        _resultKeyDoor = $"{PlayerObjects.COUNT_KEY}";
        _textKeyDoor.text = _resultKeyDoor;

        _resultKeyForPC = $"{PlayerObjects.KEY_FOR_PC}";
        _textKeyForPC.text = _resultKeyForPC;

		_resultCoins = $"{PlayerObjects.COINS}";
		_textCoins.text = _resultCoins;

        _resultHealthPlayer = $"{PlayerObjects.HEALTH_POINTS}";
        _textHealthPlayer.text = _resultHealthPlayer;
    }
}
