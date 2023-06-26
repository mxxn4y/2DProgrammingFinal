using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFire : MonoBehaviour //마우스 클릭 위치 따라 총알 발사
{
    public GameObject bulletFactory; //총알 생성 프리팹
    public Transform pos; //총알 발사 위치 Transform 컴포넌트
    public float cooltime; //총알의 발사 쿨타임 설정
    private float curtime; //현재 경과 시간

    void Start()
    {
        
    }

    void Update()
    {
        Vector2 len = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        // ScreenToWorldPoint()로 마우스 클릭을 입력 받는 좌표

        float z = Mathf.Atan2(len.y, len.x) * Mathf.Rad2Deg;
        // 대포 위치와 마우스 위치 사이의 아크탄젠트 값을 계산

        transform.rotation = Quaternion.Euler(0, 0, z);
        // Euler 각도를 Quaternion 회전으로 변환

        if (curtime <= 0) //총알 발사 시간 간격 체크
        {
            if (Input.GetMouseButton(0)) //마우스 좌클릭 입력을 받으면 
            {
                Instantiate(bulletFactory, pos.position, transform.rotation);
                //bulletFactory 프리팹을 총알발사위치와 대포의 회전값으로 인스턴스화하여 총알을 생성
            }
            curtime = cooltime;
            // cooltime 값을 다시 설정하여 발사 간격을 조절
        }
        curtime -= Time.deltaTime;
        //경과 시간 업데이트
    }
}
