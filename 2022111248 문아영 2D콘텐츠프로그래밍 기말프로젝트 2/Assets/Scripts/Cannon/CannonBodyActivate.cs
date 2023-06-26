using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonBodyActivate: MonoBehaviour
{

    public GameObject CannonBody; //대포 몸체 게임오브젝트
    public GameObject PressToUse; //대포 바퀴와 충돌 시 팝업될 UI
    public GameObject CannonWheel; //대포 바퀴 게임오브젝트

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player") //Player와 충돌하면
        {
            PressToUse.SetActive(true); //팝업 UI 활성화
            Invoke("RemovePTU", 1); //1초 뒤 RemovePTU() 메서드 실행
        }
        if (collision.gameObject.name == "Player" && Input.GetKey(KeyCode.Space)) //Player와 충돌하고 Space바를 누르면
        {
            CannonBody.SetActive(true); //대포 몸체를 활성화
            if(CannonBody.activeSelf == true) //대포 몸체가 활성화 되어 있는 상태에서는
            {
                PressToUse.SetActive(false); //팝업 UI를 비활성화
            }
        }
    }

    void RemovePTU()
    {
        PressToUse.SetActive(false); //팝업 UI 비활성화 
    }

    
    public void Disactivate()
    {
        //대포 몸체와 대포 바퀴를 비활성화
        CannonBody.SetActive(false);
        CannonWheel.SetActive(false);
    }
    

    void Start()
    {
        //시작 시 대포 몸체와 팝업 UI는 비활성화 상태
        CannonBody.SetActive(false);
        PressToUse.SetActive(false);
    }

    void Update()
    {
        
    }
}
