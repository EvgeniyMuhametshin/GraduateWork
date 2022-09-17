using TMPro;
using UnityEngine;

public class UIPlayer : MonoBehaviour
{
    [SerializeField]
    public Inventory _inventory;
    [SerializeField]
    public TMP_Text _text;

    private string _countKey;

    private void Start()
    {
        _inventory = (Inventory)Resources.Load("ScriptableObjects/Inventory");
	}

    private void Update()
    {
		_countKey = $"{_inventory.Key}";
		_text.text = _countKey;
    }
}
