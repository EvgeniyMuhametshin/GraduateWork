using UnityEngine;

public class EnemyGenerated : MonoBehaviour
{
	[SerializeField]
	private Sprite _sprite;

	private GeneratedCharacterEnemy _generatedCharacterEnemy;

	//генерация врага
	private void Start()
	{
		_generatedCharacterEnemy = new GeneratedCharacterEnemy();

		_generatedCharacterEnemy.Generated(new Vector3(1, 1, 1), new Vector3(-26.5f, -16.18f, 0),
			Quaternion.Euler(0, 0, 0), "Enemy", 6, _sprite);
	}
}
