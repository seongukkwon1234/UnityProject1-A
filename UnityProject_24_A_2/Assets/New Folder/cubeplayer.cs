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
        { //������Ʈ�� y���� -2 �����̰ų� 2�̻��ϰ�� ���ǹ�
            TextUI.text = "����";
            Count = 0;     //���н� ī���� �ʱ�ȭ
        }

    }
}
