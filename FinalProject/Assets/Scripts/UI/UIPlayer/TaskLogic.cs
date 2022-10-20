using UnityEngine;
using UnityEngine.UI;

public class TaskLogic : MonoBehaviour
{
    [SerializeField]
    private Toggle _tasks;

    private void Start()
    {
        _tasks.interactable = false;
    }

    private void Update()
    {
        if (PlayerObjects.COUNT_KEY >= 2)
        {
            _tasks.interactable = true;
        }
    }
}
