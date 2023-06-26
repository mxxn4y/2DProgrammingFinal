using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target; //target이라는 이름의 Transform(게임오브젝트 위치, 회전, 크기정보 나타내는 컴포넌트) 변수 선언
    //player의 위치, 회전, 크기정보를 받아오고, MainCamera와 Player의 동선을 일치

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
        //현재 객체의 위치를 target 객체의 위치와 일치
    }
}
