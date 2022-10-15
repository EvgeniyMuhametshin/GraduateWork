using UnityEngine;

public class CatHealth : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (PlayerObjects.HEALTH_POINTS < 100 && PlayerObjects.COINS > 0)
            {
                PlayerObjects.HEALTH_POINTS += 10;
                PlayerObjects.COINS -= 1;
            }
        }
    }
}
