using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubeplayer : MonoBehaviour
{
    public Text TextUI = null;
    public int Count = 0;     
    public float Power = 100;
    public Rigidbody m_Rigidbody;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Keycode.space))


        {
            Count += 1;
            TextUI.text = Count.ToString();
            Power = Random.Range(100, 200);
            m_Rigidbody.AddForce(transform.up * Power);

        }

        if (gameObject.transform.position.y >= 2 || gameObject.transform.position.y <= -2)
        { //오브젝트의 y값이 -2 이하이거나 2이상일경우 조건문
            TextUI.text = "실패";
            Count = 0;     //실패시 카운터 초기화
        }

    }
}
