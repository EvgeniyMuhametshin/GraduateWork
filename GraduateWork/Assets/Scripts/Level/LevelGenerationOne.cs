using UnityEngine;

public class LevelGenerationOne : MonoBehaviour
{
    [SerializeField]
    private Sprite[] _sprites;

    private IGenerationLevel _planeLevel;
    private IGenerationLevel _wallsLevel;

	//var sprite = Resources.Load<Sprite>("Sprites/Characters/Level/Floor and Walls_0");
    void Start()
    {
		#region PlaneLevel
		_planeLevel = new PlaneLevel();
        _planeLevel.Generated(new Vector3(5, 5, 5), new Vector3(0,0,0), 
            Quaternion.Euler(0, 0, 90), "LevelOne", 8, _sprites[0]);
		_planeLevel.Generated(new Vector3(2, 2, 2), new Vector3(-16, 0, 0),
			Quaternion.Euler(0, 0, 0), "LevelOne", 8, _sprites[0]);
		_planeLevel.Generated(new Vector3(5, 2, 2), new Vector3(-26, 4, 0),
			Quaternion.Euler(0, 0, 90), "LevelOne", 8, _sprites[0]);
		_planeLevel.Generated(new Vector3(1, 1, 1), new Vector3(-19, 15, 0),
			Quaternion.Euler(0, 0, 0), "LevelOne", 8, _sprites[0]);
		_planeLevel.Generated(new Vector3(3, 3, 3), new Vector3(-26, -17, 0),
			Quaternion.Euler(0, 0, 0), "LevelOne", 8, _sprites[0]);
		#endregion

		#region WallsLevel
		_wallsLevel = new WallsLevel();
        _wallsLevel.Generated(new Vector3(5,1,1), new Vector3(0,15,0), 
            Quaternion.Euler(0,0,0), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(5, 1, 1), new Vector3(0, -15, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(8, 1, 1), new Vector3(10, 0, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(3, 1, 1), new Vector3(-10, 9, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(3, 1, 1), new Vector3(-10, -9, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);

		_wallsLevel.Generated(new Vector3(2.8f, 1, 1), new Vector3(-16, 4, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(2.8f, 1, 1), new Vector3(-16, -4, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(2.2f, 1, 1), new Vector3(-22, 9, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(0.60f, 1, 1), new Vector3(-22, 18, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);

		_wallsLevel.Generated(new Vector3(2.8f, 1, 1), new Vector3(-25, 19, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(2.8f, 1, 1), new Vector3(-16, 17, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(2.8f, 1, 1), new Vector3(-16, 13, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(2.2f, 1, 1), new Vector3(-16, 15, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(8, 1, 1), new Vector3(-30, 7, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);

		_wallsLevel.Generated(new Vector3(1.6f, 1, 1), new Vector3(-22, -7.6f, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(3, 1, 1), new Vector3(-17, -17, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(3, 1, 1), new Vector3(-35, -17, 0),
			Quaternion.Euler(0, 0, 90), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(5, 1, 1), new Vector3(-25, -23, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);

		_wallsLevel.Generated(new Vector3(2.8f, 1, 1), new Vector3(-16, -11, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(2.8f, 1, 1), new Vector3(-36, -11, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);
		_wallsLevel.Generated(new Vector3(4, 1, 1), new Vector3(9, 2, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[2]);

		_wallsLevel.Generated(new Vector3(2, 1, 1), new Vector3(-4.5f, -14, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[4]);
		_wallsLevel.Generated(new Vector3(2, 1, 1), new Vector3(4.5f, -14, 0),
			Quaternion.Euler(0, 0, 0), "Walls", 3, _sprites[4]);
		#endregion
	}
}
