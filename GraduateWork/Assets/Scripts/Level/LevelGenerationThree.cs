using UnityEngine;

public class LevelGenerationThree : MonoBehaviour
{
	[SerializeField]
	private Sprite[] _sprites;

	private IGenerations _planeLevel;
	private IGenerations _wallsLevel;

	void Start()
    {
		#region PlaneLevel
		_planeLevel = new PlaneLevel();
		_planeLevel.Generated(new Vector3(5, 5, 2), new Vector3(0, 0, 0),
			Quaternion.Euler(0, 0, 0), "LevelThree", 8, _sprites[0]);
		_planeLevel.Generated(new Vector3(2, 2, 2), new Vector3(9, 14, 0),
			Quaternion.Euler(0, 0, 0), "LevelThree", 8, _sprites[0]);
		_planeLevel.Generated(new Vector3(1, 1, 2), new Vector3(0, 16, 0),
			Quaternion.Euler(0, 0, 0), "LevelThree", 8, _sprites[0]);
		_planeLevel.Generated(new Vector3(2, 2, 2), new Vector3(9, -14, 0),
			Quaternion.Euler(0, 0, 0), "LevelThree", 8, _sprites[0]);
		_planeLevel.Generated(new Vector3(2, 1, 2), new Vector3(-3, -16, 0),
			Quaternion.Euler(0, 0, 0), "LevelThree", 8, _sprites[0]);
		_planeLevel.Generated(new Vector3(2, 2, 2), new Vector3(-14.66f, -15.5f, 0),
			Quaternion.Euler(0, 0, 0), "LevelThree", 8, _sprites[0]);
		#endregion

		#region WallsLevel
		_wallsLevel = new WallsLevel();
		_wallsLevel.Generated(new Vector3(6, 1, 1), new Vector3(-2, 10, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(6, 1, 1), new Vector3(5.3f, 18, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(6, 1, 1), new Vector3(-2, -10, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(6, 1, 1), new Vector3(4.25f, -18, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(6, 1, 1), new Vector3(-14.75f, -19.5f, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(6, 1, 1), new Vector3(-14.75f, -11.5f, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(2.72f, 1, 1), new Vector3(-2.85f, -14, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(1.6f, 1, 1), new Vector3(-0.6f, 14, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);

		_wallsLevel.Generated(new Vector3(2.72f, 1, 1), new Vector3(-20.6f, -15.4f, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(0.8f, 1, 1), new Vector3(-8.72f, -12.27f, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(0.8f, 1, 1), new Vector3(-8.72f, -19.77f, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(0.9f, 1, 1), new Vector3(3, -12, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(0.9f, 1, 1), new Vector3(3, 12, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(0.9f, 1, 1), new Vector3(-3, 16, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(4.65f, 1, 1), new Vector3(-15f, 0, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(8.5f, 1, 1), new Vector3(15, 0, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);

		#endregion
	}
}
