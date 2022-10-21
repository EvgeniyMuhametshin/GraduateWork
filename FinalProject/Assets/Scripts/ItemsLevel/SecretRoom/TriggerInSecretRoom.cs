using UnityEngine;

public class TriggerInSecretRoom : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _animator.SetBool("GoodBuyPlay", true);
        }
    }
}
