using UnityEngine;

public class LevelGenerationTwo : MonoBehaviour
{
    [SerializeField]
    private Sprite[] _sprites;

	private IGenerations _planeLevel;
	private IGenerations _wallsLevel;
	private ObjectKey _key;

	void Start()
    {
		#region Key
		_key = new ObjectKey();
		_key.Generated(new Vector3(2, 2, 2), new Vector3(-70, 32, 0),
			Quaternion.Euler(0, 0, 0), "LevelTwo", 8, _sprites[8]);
		#endregion

		#region PlaneLevel
		_planeLevel = new PlaneLevel();
		_planeLevel.Generated(new Vector3(5, 6, 2), new Vector3(0, 0, 0),
			Quaternion.Euler(0, 0, 0), "LevelTwo", 8, _sprites[0]);
		_planeLevel.Generated(new Vector3(8, 2.5f, 2), new Vector3(-38, -7, 0),
			Quaternion.Euler(0, 0, 0), "LevelTwo", 8, _sprites[0]);
		_planeLevel.Generated(new Vector3(8, 2.5f, 2), new Vector3(-67, 12, 0),
			Quaternion.Euler(0, 0, 90), "LevelTwo", 8, _sprites[0]);
		#endregion

		#region WallsLevel
		_wallsLevel = new WallsLevel();
		_wallsLevel.Generated(new Vector3(7.25f, 1, 1), new Vector3(0, 12, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(20, 1, 1), new Vector3(-28.7f, -12, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(11, 1, 1), new Vector3(-38.46f, -2, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(3, 1, 1), new Vector3(-67, 34, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);

		_wallsLevel.Generated(new Vector3(10.6f, 1, 1), new Vector3(-72, 11, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(10.6f, 1, 1), new Vector3(-62, 21, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(3.9f, 1, 1), new Vector3(-14.8f, 6.3f, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(6, 1, 1), new Vector3(14.75f, 0, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);
		#endregion
	}
}
