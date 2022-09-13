using UnityEngine;

public class ObjectGeneratedOne : MonoBehaviour
{
    [SerializeField]
    private Sprite[] _sprites;

    private IGenerations _objectGenerationsStairLevelTwo;
    private IGenerations _objectGenerationsStairLevelThree;

    private void Start()
    {
        _objectGenerationsStairLevelTwo = new ObjectsGeneratedStairLevelTwo();
        _objectGenerationsStairLevelThree = new ObjectsGeneratedStairLevelThree();
        //Stairs
        _objectGenerationsStairLevelTwo.Generated(new Vector3(5,5,5), new Vector3(4.51f,13.39f,0),
            Quaternion.Euler(0,0,0), "LevelOne", 8, _sprites[0]);
		_objectGenerationsStairLevelThree.Generated(new Vector3(4, 4, 4), new Vector3(-19.6f, 15, 10),
			Quaternion.Euler(0, 0, 90), "LevelOne", 8, _sprites[1]);
	}
}
