using UnityEngine;

public interface IGenerations 
{
    public void Generated(Vector3 scale, Vector3 positions, Quaternion rotations,
		string tag, int layer, Sprite sprites);
}
