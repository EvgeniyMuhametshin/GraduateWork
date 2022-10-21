using UnityEngine;

public class UIKeyboardCloase : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameObject;

    private void Start()
    {
        Time.timeScale = 0f;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Time.timeScale = 1f;
            _gameObject.SetActive(false);
        }
    }
}