using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Rigidbody2D rigid; //물리 컴포넌트

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>(); //Rigidbody2D 호출, rigid로 정의
    }

    void Update()
    {
        float enemySpeed = -0.002f; //적 미사일의 속도를 -0.002f로 설정
        transform.Translate(0, enemySpeed, 0); //적 미사일이 등속 낙하

        if (transform.position.y < -15.0f) //적 미사일이 화면을 벗어나면
        {
            Destroy(gameObject); //적 미사일 오브젝트를 제거
        }
    }

}
