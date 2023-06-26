using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mission23 : MonoBehaviour
{

    public GameObject mission23Zone; //mission2-3을 수행할 수 있는 게임오브젝트
    public GameObject mission23Slider; //mission2-3의 진척도를 표시하는 슬라이더 UI
    public GameObject mission23Special;//mission2-3 클리어 시 mission23Zone의 위치에 활성화 되는 특별 UI 

    void Start()
    {
        mission23Zone.SetActive(false); //시작 시 mission2-3 수행존은 비활성화
        Invoke("mission23Activate", 20); //mission2-3은 시작 후 20초 뒤 mission23Activate() 메서드로 실행
        mission23Special.SetActive(false); //시작 시 mission2-3의 특별 UI는 비활성화
    }

    void Update()
    {

    }

    void mission23Activate()
    {
        mission23Zone.SetActive(true); //mission23Activate 시 mission23Zone이 활성화 되며 mission2-3을 수행할 수 있음
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") //mission23Zone에 Player의 tag를 가진 게임오브젝트가 충돌 유지 시
        {
            GameObject director = GameObject.Find("GameDirector2"); //GameDirector2 게임오브젝트를 찾고
            director.GetComponent<GameDirector2>().IncreaseSlider23(); //GameDirector 컴포넌트의 IncreaseSlider23() 메서드 실행
        }
    }

    public void mission23Clear()
    {
        mission23Zone.SetActive(false); //mission2-3이 클리어 된다면 mission23Zone은 비활성화
        mission23Slider.SetActive(false); //mission2-3이 클리어 된다면 mission23Slider는 비활성화
        mission23Special.SetActive(true); //특별UI를 활성화
        //Invoke("LoadStage2", 9);
    }

    /*
    void LoadStage2()
    {
        SceneManager.LoadScene("Stage2");
    }
    */
}
