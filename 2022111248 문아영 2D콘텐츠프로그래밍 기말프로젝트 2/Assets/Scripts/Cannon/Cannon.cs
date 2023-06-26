using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public int cannon_currentHealth; //대포의 현재 체력
    public int cannon_maxHealth = 10; //대포의 최대 체력 = 10

    public GameObject CannonWheel; //대포 바퀴 오브젝트


    void Start()
    {
        cannon_currentHealth = cannon_maxHealth; //대포의 현재체력을 최대체력과 같게 (=10)
    }

    void Update()
    {
        if (cannon_currentHealth > cannon_maxHealth) //대포의 최대 체력이 대포의 현재 체력보다 작다면
        {
            cannon_currentHealth = cannon_maxHealth; //대포 현재 체력 값을 갱신
        }

        if (cannon_currentHealth <= 0) //대포의 현재 체력이 0보다 작거나 같다면
        {
            if (CannonWheel.activeSelf == true) //대포 바퀴 오브젝트의 활성화 상태가 true라면
            {
                GameObject cannonbody = GameObject.Find("CannonWheel"); //CannonWheel이라는 이름의 오브젝트를 찾아서 cannonbody에 할당
                cannonbody.GetComponent<CannonBodyActivate>().Disactivate(); //CannonBodyActivate 클래스의 Disactivate() 메서드 실행
                // (= 대포 체력이 다 소진될 시 비활성화 상태가 되는 것 구현)
            }
        }
    }

    public void DecreaseHP()
    {
        cannon_currentHealth--; //대포의 현재 체력을 감소
    }
}
