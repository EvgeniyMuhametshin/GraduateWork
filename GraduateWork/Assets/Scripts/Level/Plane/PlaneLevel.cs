using UnityEngine;

public class PlaneLevel : IGenerations
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
		gameObject.GetComponent<SpriteRenderer>().sortingOrder = -1;
		gameObject.GetComponent<SpriteRenderer>().material = (Material)Resources.Load("Material/GlobalLight");

		gameObject.AddComponent<MeshCollider>();
	}
}
