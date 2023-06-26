using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonHUD : MonoBehaviour //대포의 체력에 따라 UI이미지 업데이트
{
    public Sprite[] CannonHeartSprites; //대포의 체력에 따라 변경될 Sprite 배열
    public Image CannonHeartUI; //대포 체력을 나타내는 UI 이미지를 참조하는 Image 컴포넌트
    private Cannon c; //Cannon 클래스 참조 변수

    void Start()
    {
        c = GameObject.FindGameObjectWithTag("Cannon").GetComponent<Cannon>();
        //Cannon 태그를 가진 게임오브젝트를 찾고 Cannon 컴포넌트를 가져와서 c에 할당
    }

    void Update()
    {
        CannonHeartUI.sprite = CannonHeartSprites[c.cannon_currentHealth];
        //CannonHeartUI의 sprite를 Sprite배열에서 cannon의 현재 체력에 해당하는 sprite로 설정
    }
}
