using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector2 : MonoBehaviour
{
    GameObject mission2Slider1;
    GameObject mission2Slider2;
    GameObject mission2Slider3;
    //미션 2-1, 2-2, 2-3 진척도 슬라이더 게이지 게임오브젝트
	
    float missionLoad1;
    float missionLoad2;
    float missionLoad3;
    //미션 2-1, 2-2, 2-3 진척도 슬라이더 게이지를 함께 카운팅할 변수

    bool isMission21Clear = false;
    bool isMission22Clear = false;
    bool isMission23Clear = false;
    //미션 2-1, 2-2, 2-3이 클리어 됐는지 판단할 bool형 변수, 초기값은 false

    public GameObject mission2Coin;
    //미션 클리어 시 왼쪽 상단에 표시될 미션2완료 코인 UI

    void Start()
    {
        this.mission2Slider1 = GameObject.Find("missionSlider21");
        this.mission2Slider2 = GameObject.Find("missionSlider22");
        this.mission2Slider3 = GameObject.Find("missionSlider23");
        //mission2Slider1(,2,3)라는 이름의 게임 오브젝트를 찾아 missionSlider2(1,2,3)에 할당

        missionLoad1 = 0;
        missionLoad2 = 0;
        missionLoad3 = 0;
        //missionLoad1,2,3은 각각 0으로 할당

        mission2Coin.SetActive(false);
        //미션 클리어 시 왼쪽 상단에 표시될 미션2완료 코인 UI는 시작 시 비활성화 상태
    }

    void Update()
    {

    }

    public void IncreaseSlider21()
    {
        this.mission2Slider1.GetComponent<Image>().fillAmount += 0.003f;
        //slider의 게이지를 0.003f 씩 증가, fillAmount로 게이지 이미지가 점점 차오름
        //Stage1보다 낮은 증가율 = 난이도 증가

        missionLoad1 += 0.003f; // 진척도 변수 또한 같은 값으로 증가
        if (missionLoad1 >= 1) //만약 미션2-1의 진척도가 1보다 크거나 같은 값이 되었다면
        {
            is21Clear(); //is21Clear() 메서드 호출
        }
    }

    public void IncreaseSlider22()
    {
        this.mission2Slider2.GetComponent<Image>().fillAmount += 0.003f;
        //slider의 게이지를 0.003f 씩 증가, fillAmount로 게이지가 점점 차오름

        missionLoad2 += 0.003f; // 진척도 변수 또한 같은 값으로 증가
        if (missionLoad2 >= 1) //만약 미션2-2의 진척도가 1보다 크거나 같은 값이 되었다면
        {
            is22Clear(); //is22Clear() 메서드 호출
        }
    }

    public void IncreaseSlider23()
    {
        this.mission2Slider3.GetComponent<Image>().fillAmount += 0.003f;
        //slider의 게이지를 0.003f 씩 증가, fillAmount로 게이지가 점점 차오름
        missionLoad3 += 0.003f; // 진척도 변수 또한 같은 값으로 증가

        if (missionLoad3 >= 1) //만약 미션2-3의 진척도가 1보다 크거나 같은 값이 되었다면
        {
            is23Clear(); //is23Clear() 메서드 호출
        }
    }


    public void is21Clear()
    {
        GameObject mission2clear = GameObject.Find("Mission21"); //Mission21이라는 게임오브젝트를 찾아 mission2clear에 할당
        mission2clear.GetComponent<Mission21>().mission21Clear(); //Mission21 컴포넌트의 mission21Clear() 메서드를 실행
        isMission21Clear = true; //미션 2-1, 2-2, 2-3이 클리어 됐는지 판단할 bool형 변수를 true로 할당
        is2AllClear(); //is2AllClear() 메서드를 호출

    }
    public void is22Clear()
    {
        GameObject mission2clear = GameObject.Find("Mission22"); //Mission22이라는 게임오브젝트를 찾아 mission2clear에 할당
        mission2clear.GetComponent<Mission22>().mission22Clear(); //Mission22 컴포넌트의 mission22Clear() 메서드를 실행
        isMission22Clear = true; //미션 2-1, 2-2, 2-3이 클리어 됐는지 판단할 bool형 변수를 true로 할당
        is2AllClear(); //is2AllClear() 메서드를 호출

    }
    public void is23Clear()
    {
        GameObject mission2clear = GameObject.Find("Mission23"); //Mission23이라는 게임오브젝트를 찾아 mission2clear에 할당
        mission2clear.GetComponent<Mission23>().mission23Clear(); //Mission23 컴포넌트의 mission23Clear() 메서드를 실행
        isMission23Clear = true; //미션 2-1, 2-2, 2-3이 클리어 됐는지 판단할 bool형 변수를 true로 할당
        is2AllClear(); //is2AllClear() 메서드를 호출

    }
    public void is2AllClear()
    {
        if((isMission21Clear && isMission22Clear && isMission23Clear) == true)
        { //미션 2-1, 2-2, 2-3이 클리어 됐는지 판단할 bool형 변수들이 모두 true 값이라면
            mission2Coin.SetActive(true); //mission2Coin을 활성화
            Invoke("Clear2", 8); //8초 뒤 Clear2() 메서드를 실행
        }
    }

    void Clear2()
    {
        SceneManager.LoadScene("Clear2"); //Clear2씬을 로드
    }
}
