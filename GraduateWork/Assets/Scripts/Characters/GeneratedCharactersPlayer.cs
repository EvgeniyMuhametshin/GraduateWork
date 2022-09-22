using UnityEngine;

public class GeneratedCharactersPlayer
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
		gameObject.AddComponent<Rigidbody2D>();

		gameObject.GetComponent<Rigidbody2D>().simulated = true;
		gameObject.GetComponent<Rigidbody2D>().mass = 0f;
		gameObject.GetComponent<Rigidbody2D>().gravityScale = 0f;
		gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;

		gameObject.GetComponent<BoxCollider2D>().size = new Vector2(2,1);

		gameObject.AddComponent<Light>();

		gameObject.AddComponent<Animator>();
		gameObject.GetComponent<Animator>().runtimeAnimatorController = (RuntimeAnimatorController)Resources.
			Load("Animation/Player/Sprite-0002");

		return gameObject;
	}
}
