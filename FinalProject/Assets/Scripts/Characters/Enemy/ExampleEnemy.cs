using UnityEngine;

public class ExampleEnemy : MonoBehaviour
{
	public float speed;
	public int spot = 0;
	public int next = 1;
	public Transform[] moveSpots;

	private float waitTime;
	public float startWaitTime = 3;

	private void Start()
	{
		waitTime = startWaitTime;
	}

	void Update()
	{
		transform.position = Vector3.MoveTowards(transform.position, moveSpots[spot].position, speed * Time.deltaTime);

		if (Vector2.Distance(transform.position, moveSpots[spot].position) < 0.2f)
		{
			if (waitTime <= 0)// Timer 
			{
				if (spot == moveSpots.Length - 1)
				{
					next = -1;
					waitTime = startWaitTime;
				}

				if (spot == 0)
				{
					next = 1;
					waitTime = startWaitTime;
				}

				spot += next;
			}
			else
			{
				waitTime -= Time.deltaTime;
			}
		}
	}
}