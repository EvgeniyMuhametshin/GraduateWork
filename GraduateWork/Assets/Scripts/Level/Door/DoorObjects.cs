using UnityEngine;

public class DoorObjects 
{
	public GameObject Generated(Vector3 scale, Vector3 positions,
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

		gameObject.AddComponent<BoxCollider2D>();
		gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
		gameObject.GetComponent<BoxCollider2D>().size = new Vector2(2,0.5f);

		gameObject.GetComponent<SpriteRenderer>().material = (Material)Resources.Load("Material/GlobalLight");
		gameObject.AddComponent<DoorActions>();

		return gameObject;
	}
}
