using TMPro;
using UnityEngine;

public class MessagePC : MonoBehaviour
{
    [SerializeField]
    private TMP_Text[] _canvasMessages;

    private bool _flag;

    private void Start()
    {
        for (int i = 0; i < _canvasMessages.Length; i++)
        {
            _canvasMessages[i].enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (PlayerObjects.keyForPC == 1)
        {
            _flag = true;
        }
        if (_flag == true)
        {
            _canvasMessages[0].enabled = true;
        }
        else if (_flag == false)
        {
            _canvasMessages[1].enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            for (int i = 0; i < _canvasMessages.Length; i++)
            {
                _canvasMessages[i].enabled = false;
            }
        }
    }
}
