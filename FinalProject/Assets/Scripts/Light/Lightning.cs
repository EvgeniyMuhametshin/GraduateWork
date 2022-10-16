using UnityEngine;

public class Lightning : MonoBehaviour
{
    [SerializeField]
    private Light _lightning;
    [SerializeField]
    private AudioSource _source;

    //TODO Добавить рандомное значение 
    private float waitTime;
    private float startWaitTime = 30;//Рандомное значение

    private void Start()
    {
        _lightning.intensity = 1;
    }

    private void Update()
    {
        if (waitTime <= 0)
        {
            _lightning.intensity = 5;
            _source.Play();
            waitTime = startWaitTime;
        }
        else
        {
            _lightning.intensity -= Time.deltaTime;
            waitTime -= Time.deltaTime;
        }
    }
}
