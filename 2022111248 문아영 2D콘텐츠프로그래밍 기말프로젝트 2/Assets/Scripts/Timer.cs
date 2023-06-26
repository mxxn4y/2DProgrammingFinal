using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public float LimitTime; //제한시간 변수
    public Text textTimer; //Text UI 컴포넌트 참조 변수

    void Start()
    {

    }

    void Update()
    {
        LimitTime -= Time.deltaTime; //제한시간에 측정 시간을 누적 감소
        textTimer.text = "" + Mathf.Round(LimitTime); //LimitTime 변수를 반올림 후 문자열로 변환, text 속성에 할당
        if(LimitTime < 0) //제한 시간이 0보다 작다면
        {
            LimitTime = 0; //제한시간이 0이 되면 (=제한 시간 안에 스테이지를 클리어 하지 못하면)
            SceneManager.LoadScene("Fail"); //Fail씬을 로드
        }
    }

}
