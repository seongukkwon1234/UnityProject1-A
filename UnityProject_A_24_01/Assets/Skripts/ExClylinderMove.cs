using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExClylinderMove : MonoBehaviour
{
    public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���� ������Ʈ�� ��ǥ ����
        // Vector3 (X,Y,Z) ���� �ǹ��Ѵ�. new �� Vector Ŭ������ ���� ���ؼ� ����
        // X = X + 5 <- X+= 5 (��� ǥ��)
        // Time.seltaTime ������ ���� �ð� ex) 60fps �� ��� 0.1�ʶ�� ��ġ�� ��ȯ ���ش�.
        // ��ǻ�� ���� �������� �޶� ������ �̵� �ӵ��� ������� �ϱ� ������ ���
        gameObject.transform.position += new Vector3(-1.0f, 0.0f, 0.0f) * speed * Time.deltaTime;

        //�� ������Ʈ�� X ��ǥ�� -12 �̸��� ���
        if (gameObject.transform.position.x < -16.0f)
        {
            gameObject.transform.position += new Vector3(32.0f, 0.0f, 0.0f);
            // X�࿡ 24 ���ؼ� ȭ�� ���������� �̵������ش�.
        }
    }
}
