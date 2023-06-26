using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMoves : MonoBehaviour
{

    Rigidbody2D rigid; //물리 컴포넌트

    private Camera _camera; // 메인 카메라를 받아올 변수

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();//Rigidbody2D 호출, rigid로 정의

        _camera = Camera.main; // 메인카메라를 받아 메인카메라를 받아올변수에 저장
    }

    void Update()
    {
        
        Vector2 mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
        // ScreenToWorldPoint()로 마우스의 좌표를 게임 좌표로 변환

        Vector2 dirVec = mousePos - (Vector2)transform.position;
        // (마우스 위치 - 오브젝트 위치)로 마우스의 방향 구함

        transform.up = dirVec.normalized;
        // 방향벡터를 정규화해서 transform.up벡터에 계속 대입

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy") // tag가 Enemy인 오브젝트에 충돌한다면
        {
            Destroy(other.gameObject); //Enemy를 파괴
            GameObject cannon = GameObject.Find("Cannon"); // Cannon이라는 게임 오브젝트를 찾고 GameObject 변수에 할당
            cannon.GetComponent<Cannon>().DecreaseHP(); //Cannon 게임 오브젝트의 DecreaseHP() 메서드 호출, Cannon의 HP 감소
        }
    }

}