using UnityEngine;

//переход с третьего этажа на первый (ѕ≈–¬џ… Ё“ј∆ ƒќћј)
public class ObjectsGeneratedStairLevelFour : IGenerations
{
	public void Generated(Vector3 scale, Vector3 positions,
		Quaternion rotations, string tag, int layer, Sprite sprites)
	{
		var gameObject = new GameObject();
		var spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
		var sprite = sprites;
		spriteRenderer.sprite = sprite;
		gameObject.transform.rotation = rotations;
		gameObject.transform.localScale = scale;
		gameObject.tag = tag;
		gameObject.layer = layer;
		gameObject.transform.position = positions;
		gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
		gameObject.GetComponent<SpriteRenderer>().material = (Material)Resources.Load("Material/GlobalLight");
		gameObject.AddComponent<BoxCollider2D>();
		gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
		gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1, 1);
		gameObject.AddComponent<LoandingNextScene>();
		gameObject.GetComponent<LoandingNextScene>().NumberScene = 1;

		//------------------------------------------------------------------
		gameObject.GetComponent<LoandingNextScene>()._playerPositions =
			(SavePositions)Resources.Load("ScriptableObjects/PlayerPositions");
		gameObject.GetComponent<LoandingNextScene>()._position = new Vector3(-23, 15, -1);
		//------------------------------------------------------------------
	}
}
