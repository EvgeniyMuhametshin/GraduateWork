using UnityEngine;

public class CameraController 
{
    private Vector3 positionsCamera = new Vector3(0, 0, -1);

    public void Controller(Transform _playerTransform, Camera camera)
    {
        camera.transform.position = _playerTransform.position + positionsCamera;
    }
}
