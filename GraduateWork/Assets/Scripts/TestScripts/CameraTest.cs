using UnityEngine;

public class CameraTest : MonoBehaviour
{
    [Header("Parametrs")]
    [SerializeField]
    private Transform playerTransform;
    //[SerializeField]
    //private string playerTag;
    [SerializeField]
    private float movingSpeed;

    private void Start()
    {
        if (playerTransform == null)
        {
			playerTransform = GameObject.
			    FindGameObjectWithTag("Player").transform;
		}

        transform.position = new Vector3()
        {
            x = playerTransform.position.x,
            y = playerTransform.position.y,
            z = playerTransform.position.z - 10,
        };
    }

    private void Update()
    {
        if (playerTransform)
        {
            Vector3 target = new Vector3()
            {
                x = playerTransform.position.x,
                y = playerTransform.position.y,
                z = playerTransform.position.z - 10,
            };

            Vector3 pos = Vector3.Lerp(transform.position,
                target, movingSpeed * Time.deltaTime);

            transform.position = pos;
        }
    }
}
