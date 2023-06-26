using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed; //총알 속도 설정 변수

    Rigidbody2D rigid; //물리 컴포넌트

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>(); //Rigidbody2D 호출, rigid로 정의
        Invoke("DestroyBullet", 2); //DestroyBullet 메서드를 2초 뒤 실행, Enemy에 충돌하지 않아도 발사 2초 뒤에 총알이 파괴되도록함
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); //총알의 위치를 Vector2 오른쪽 * 총알 속도 * 시간 당
    }

    void DestroyBullet() //Bullet 오브젝트를 파괴하는 메서드
    {
        Destroy(gameObject); //Bullet 오브젝트를 Destroy
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy") //tag가 Enemy인 오브젝트에 충돌한다면
        {
            Destroy(other.gameObject); //Enemy를 파괴
            DestroyBullet(); //DestroyBullet 메서드 실행
        }
    }
}
