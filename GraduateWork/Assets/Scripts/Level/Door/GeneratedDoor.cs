using UnityEngine;

public class GeneratedDoor : MonoBehaviour
{
	[SerializeField]
	private Sprite[] _sprites;

	private DoorObjects _objects;

	private void Start()
	{
		_objects = new DoorObjects();
		_objects.Generated(new Vector3(5, 3, 5), new Vector3(0, -14.8f, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[0]);
	}
}
