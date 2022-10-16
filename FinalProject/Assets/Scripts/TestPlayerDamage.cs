using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestPlayerDamage : MonoBehaviour
{
    [SerializeField]
    private Image m_Image;

    private void Start()
    {
        m_Image.color = new Color(0,0,0,0);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            
			Debug.Log(m_Image.color);
        }
    }
}
