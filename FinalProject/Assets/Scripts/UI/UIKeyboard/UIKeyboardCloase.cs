using UnityEngine;

public class UIKeyboardCloase : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameObject;

    private void Start()
    {
        Time.timeScale = 0f;
    }

    //TODO А при загрузке первой сцены при старте игры KEYBOARD_MENU == false
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Time.timeScale = 1f;
            _gameObject.SetActive(false);
            PlayerObjects.KEYBOARD_MENU = true;
        }
        if (PlayerObjects.KEYBOARD_MENU == true)
        {
			Time.timeScale = 1f;
			_gameObject.SetActive(false);
        }
    }
}