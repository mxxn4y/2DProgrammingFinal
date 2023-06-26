using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float Speed; //플레이어의 속도를 지정할 변수

    Rigidbody2D rigid; //물리 컴포넌트

    float h; //Horizontal 값을 배정할 변수 h
    float v; //Vertical 값을 배정할 변수 v
    bool isHorizonMove; //플레이어가 Horizon 방향으로 움직였는지 판단할 bool형 변수 

    Animator anim; //플레이어 애니메이션을 사용하기 위함

    public int currentHealth; //플레이어의 현재 체력 
    public int maxHealth = 10; //플레이어의 최대 체력 = 10

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>(); //Rigidbody2D 호출, rigid로 정의
        anim = GetComponent<Animator>(); //Animator 호출, anim로 정의

        currentHealth = maxHealth; //플레이어의 현재 체력을 최대 체력으로 저장 ( = 10 )
    }
    
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal"); //수평 입력값 저장
        v = Input.GetAxisRaw("Vertical"); //수직 입력값 저장

        bool hDown = Input.GetButton("Horizontal"); //Horizontal Down
        bool vDown = Input.GetButton("Vertical"); //Vertical Down
        bool hUp = Input.GetButton("Horizontal"); //Horizontal Up
        bool vUp = Input.GetButton("Vertical"); //Vertical Up

        if (hDown) //수평 이동 누르고 있다면
            isHorizonMove = true; //isHorizonMove = true
        else if (vDown) //그렇지 않다면
            isHorizonMove = false; //false

        anim.SetInteger("hAxisRaw", (int)h); //Animator에 수평 입력 값 전달
        anim.SetInteger("vAxisRaw", (int)v); //Animator에 수직 이동 값 전달

        Vector2 moveVec = isHorizonMove ? new Vector2(h, 0) : new Vector2(0, v);
        rigid.velocity = moveVec * Speed;

        if (currentHealth > maxHealth) //만약 최대 체력이 현재 체력보다 작다면
        {
            currentHealth = maxHealth; //현재 체력에 최대 체력을 배정
        }

        if (currentHealth <= 0) //현재 체력이 0보다 작거나 같다면 
        {
            Die(); //Die() 메서드 호출
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy") //tag가 Enemy인 오브젝트와 충돌하면
        {
            Destroy(other.gameObject); //Enemy 오브젝트를 파괴하고 
            currentHealth--; //현재 체력을 1 감소
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "NPC") //tag가 NPC인 오브젝트와 충돌하면
        {
            SceneManager.LoadScene("Stage1_Sc2"); //Stage1_Sc2씬 로드
        }
    }

        void Die()
    {
        SceneManager.LoadScene("Fail"); //Fail씬 로드
    }
}
