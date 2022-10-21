using UnityEngine;

public class PCLogic : MonoBehaviour
{
    [SerializeField]
    private Animator _animatorPC;

    [SerializeField]
    private Animator _animatorDoorSecret;

    //TODO Maybe error!!!↓↓↓ in Start
    private void Start()
    {
        _animatorDoorSecret = GameObject.FindGameObjectWithTag("DoorSecret").GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (PlayerObjects.KEY_FOR_PC >= 1)
        {
            _animatorPC.SetBool("Work", true);
            _animatorDoorSecret.SetBool("OpenDoorAction", true);
            PlayerObjects.KEY_FOR_PC--;
        }
        else
        {
            Debug.Log("PC is needing key");
        }
    }
}
