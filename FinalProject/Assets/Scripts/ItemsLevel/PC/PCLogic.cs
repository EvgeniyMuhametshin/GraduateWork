using UnityEngine;

public class PCLogic : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (PlayerObjects.KEY_FOR_PC >= 1)
        {
            _animator.SetBool("Work", true);
            Debug.Log("PC is work");
            PlayerObjects.KEY_FOR_PC--;
        }
        else
        {
            Debug.Log("PC is needing key");
        }
    }
}
