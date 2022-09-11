using UnityEngine;

public class CameraPlayer
{
    private int _speed = 5 ;
    private float _offsetX = 5, _offsetY = 5;

    private Vector3 _temp;

    public void LateUpdate(GameObject player)
    {
        _temp = player.transform.position;
        _temp.x += _offsetX;
        _temp.y += _offsetY;
        _temp.z = -10f;
        player.transform.position = Vector3.Lerp(player.transform.position, _temp, _speed * Time.deltaTime);
    }
}
