using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Main : MonoBehaviour
{
    public int Health = 100;               //ü���� �����Ѵ�.(����)
    public float Timer = 1.0f;
    public int AtteckPoint = 10;                        

    void Start()
    {
        Health += 100;           //ù ������ ������ ����� �� ü��100�� �߰� �����ش�.
    }

    // �Ź� ������ �� ȣ��ȴ�
    void Update()
    {

        CharacterHealthUp();
   

        if(Input.GetKeyDown(KeyCode.Space))
        {
            CharacterHit(AtteckPoint);
        }

        CheckDeath();    }

    public void CharacterHit(int Damage)
    {
        Health -= Damage;
    }
    void CheckDeath()
    {
        if(Health <= 0)
            Destroy(gameObject);
    }

    void CharacterHealthUp ()
    {
        Timer -= Time.deltaTime; //�ð��� �� ������ ���� ���ҽ�Ų��.(deltaTime �����Ӱ��� �ð� ������ �ǹ�)

        if (Timer <= 0)
        {
            Timer = 1.0f;
            Health += 20;
        }
    }
}
