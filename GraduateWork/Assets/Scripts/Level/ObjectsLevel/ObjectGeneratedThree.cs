using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGeneratedThree : MonoBehaviour
{
	[SerializeField]
	private Sprite[] _sprites;

	private IGenerations _objectsGeneratedStairLevelFour;

	private void Start()
	{
		_objectsGeneratedStairLevelFour = new ObjectsGeneratedStairLevelFour();

		_objectsGeneratedStairLevelFour.Generated(new Vector3(5, 5, 5), new Vector3(-14, 6.5f, 0),
			Quaternion.Euler(0, 0, 90), "LevelThree", 8, _sprites[0]);
	}
}
