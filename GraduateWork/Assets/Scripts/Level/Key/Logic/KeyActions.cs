using UnityEngine;

public class KeyActions : MonoBehaviour
{
    [SerializeField]
    private Inventory _Inventory;

    private void Start()
    {
		_Inventory = (Inventory)Resources.Load("ScriptableObjects/Inventory");
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _Inventory.Key += 1;
        }
        Debug.Log(_Inventory.Key);
        Destroy(gameObject);
    }
}
