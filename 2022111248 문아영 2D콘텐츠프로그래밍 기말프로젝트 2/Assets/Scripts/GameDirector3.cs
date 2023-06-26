using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector3 : MonoBehaviour
{
    GameObject mission3Slider; //mission3 진척도 슬라이더 게이지 게임오브젝트
    float missionLoad3; //mission3 진척도 슬라이더 게이지를 함께 카운팅할 변수

    void Start()
    {
        this.mission3Slider = GameObject.Find("mission3Slider"); //mission3Slider라는 이름의 게임 오브젝트를 찾아 mission3Slider에 할당
        missionLoad3 = 0; //missionLoad3은 0으로 할당
    }

    void Update()
    {

    }

    public void IncreaseSlider3()
    {
        this.mission3Slider.GetComponent<Image>().fillAmount += 0.0008f;
        //slider의 게이지를 0.0008f 씩 증가, fillAmount로 게이지 이미지가 점점 차오름
		//Stage1과 2보다 낮은 증가율 = 난이도 증가

        missionLoad3 += 0.0008f; //진척도 변수 또한 같은 값으로 증가
        if (missionLoad3 >= 1) //만약 진척도가 1보다 크거나 같은 값이 되었다면
        {
            is3Clear(); //is3Clear() 메서드 호출
        }
    }

    public void is3Clear()
    {
        GameObject mission3clear = GameObject.Find("Mission3"); //Mission3이라는 게임오브젝트를 찾아 mission3clear에 할당
        mission3clear.GetComponent<Mission3>().mission3Clear(); //Mission3 컴포넌트의 mission3Clear() 메서드를 실행

        Invoke("Clear3", 8); //8초 뒤 Clear3() 메서드 실행

    }
    void Clear3()
    {
        SceneManager.LoadScene("Clear3"); //Clear3 씬을 로드
    }
}