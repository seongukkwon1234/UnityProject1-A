using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;             //����Ƽ UI�� �����ϱ� ���� ���

public class EXPlayer : MonoBehaviour

{
    public int Hp = 100;
    public Text TextUI = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextUI.text = Hp.ToString();     //UI�� ü�� ǥ��         
      
        if(Input.GetMouseButtonDown(0))   //���콺 ���� �Է��� �Ǿ����� ���� 
        {
            Hp -= 10;                 //Hp = Hp - 10
            if(Hp <=0)                //ü���� 0���ϰ� �Ǹ� �ı��Ѵ�
            {
                TextUI.text = Hp.ToString();    

                Destroy(gameObject);  //game0bject�� ��ũ��Ʈ�� �پ��ִ� ������Ʈ�� ��Ī
            }
        }
    }
}
