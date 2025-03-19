using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Main : MonoBehaviour
{
    public int Health = 100;               //체력을 선언한다.(정수)
    public float Timer = 1.0f;
    public int AtteckPoint = 10;                        

    void Start()
    {
        Health += 100;           //첫 프레임 이전에 실행될 때 체력100을 추가 시켜준다.
    }

    // 매번 프레임 때 호출된다
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
        Timer -= Time.deltaTime; //시간을 매 프레임 마다 감소시킨다.(deltaTime 프레임간의 시간 간격을 의미)

        if (Timer <= 0)
        {
            Timer = 1.0f;
            Health += 20;
        }
    }
}
