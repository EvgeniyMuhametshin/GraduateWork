using UnityEngine;

public class ObjectGeneratedTwo : MonoBehaviour
{
	[SerializeField]
	private Sprite[] _sprites;

	private IGenerations _objectGeneratedStairsLevelOne;

	private void Start()
	{
		_objectGeneratedStairsLevelOne = new ObjectGeneratedStairsLevelOne();

		_objectGeneratedStairsLevelOne.Generated(new Vector3(3, 3, 3), new Vector3(-64, 34,0),
			Quaternion.Euler(0, 0, 90), "LevelTwo", 8, _sprites[0]);
	}
}
