using UnityEngine;

public class CreatPlayer : MonoBehaviour
{
	[SerializeField]
	private GameObject _prefabsPlayer;
	[SerializeField]
	private PlayerObjects _objects;

	//Start positions player new Vector3(0,-10,0)!!!
	private void Awake()
	{
		Instantiate(_prefabsPlayer, _objects.POSITIONS_PLAYER, Quaternion.identity);
	}
}
