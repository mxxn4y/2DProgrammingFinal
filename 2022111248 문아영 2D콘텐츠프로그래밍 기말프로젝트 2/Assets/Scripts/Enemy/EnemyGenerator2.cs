using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator2 : MonoBehaviour
{
    public GameObject enemyPrefab; //게임오브젝트로 enemyPrefab을 지정
    float span = 0.5f; //적 미사일이 생성 되는 속도를 0.5f로 지정
    //Stage1보다 적 미사일 생성속도가 작음. = 일정 시간 당 생성되는 적 미사일이 더 많아짐 = 난이도 상승
    float delta = 0; //시간 측정 변수

    void Start()
    {

    }

    void Update()
    {
        this.delta += Time.deltaTime; //시간 측정 변수에 경과 시간을 누적
        if (this.delta > this.span) //누적된 경과 시간보다 적 미사일 생성 속도가 작다면
        {
            this.delta = 0; //누적 시간을 0으로 초기화 하고
            GameObject go = Instantiate(enemyPrefab) as GameObject;
            // enemyPrefab을 복제하여 새로운 GameObject(go)를 생성

            int px = Random.Range(-6, 7);
            // -6부터 6까지의 랜덤한 값을 생성하여 px 변수에 저장

            go.transform.position = new Vector3(px, 7, 0);
            //적 미사일이 랜덤한 위치에서 생성됨
        }
    }
}
