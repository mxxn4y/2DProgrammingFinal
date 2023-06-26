using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject missionSlider; //mission 진척도 슬라이더 게이지 게임오브젝트
    float missionLoad; //mission 진척도 슬라이더 게이지를 함께 카운팅할 변수

    void Start()
    {
        this.missionSlider = GameObject.Find("missionSlider"); //missionSlider라는 이름의 게임 오브젝트를 찾아 missionSlider에 할당
        missionLoad = 0; //missionLoad는 0으로 할당
    }

    void Update()
    {

    }

    public void IncreaseSlider()
    {
        this.missionSlider.GetComponent<Image>().fillAmount += 0.005f;
        //slider의 게이지를 0.005f 씩 증가, fillAmount로 게이지 이미지가 점점 차오름

        missionLoad += 0.005f; //진척도 변수 또한 같은 값으로 증가
        if (missionLoad >= 1) //만약 진척도가 1보다 크거나 같은 값이 되었다면
        {
            is1Clear(); //is1Clear() 메서드 호출
        }
    }

    public void is1Clear()
    {
        GameObject mission1clear = GameObject.Find("Mission1"); //Mission1이라는 게임오브젝트를 찾아 mission1clear에 할당
        mission1clear.GetComponent<Mission1>().mission1Clear(); //Mission1 컴포넌트의 mission1Clear() 메서드를 실행

    }
}
