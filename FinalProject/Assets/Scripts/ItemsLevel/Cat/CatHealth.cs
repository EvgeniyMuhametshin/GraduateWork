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
				//Работа с альфа каналом произходит от 0 до 1.
                //где 0 это прозрачнаая материя а 1 слишком темная материя.
				PlayerObjects.COLOR_ALTHA.a -= 0.10f;
            }
        }
    }
}
