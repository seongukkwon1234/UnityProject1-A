using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExPlayer : MonoBehaviour
{
    public int Hp = 100;
    public Text TextUI = null; // ����Ƽ UI�� �����ϱ� ���� ���

    // Update is called once per frame
    void Update()
    {
        TextUI.text = Hp.ToString(); // UI ü�� ǥ��
        if(Input.GetMouseButtonDown(0)) // ���콺 ���� �Է��� �Ǿ��� ��
        {
            Hp -= 10; // Hp -10
            if(Hp <= 0) // Hp�� 0 ������ �� �ı�
            {
                Destroy(gameObject); // gameObject�� �� ��ũ��Ʈ�� ���� ������Ʈ�� �ش��
            }
        }
    }
}
