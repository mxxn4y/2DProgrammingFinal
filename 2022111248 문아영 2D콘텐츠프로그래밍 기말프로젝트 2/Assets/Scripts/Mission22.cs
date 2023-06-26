using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mission22 : MonoBehaviour
{

    public GameObject mission22Zone; //mission2-2을 수행할 수 있는 게임오브젝트
    public GameObject mission22Slider; //mission2-2의 진척도를 표시하는 슬라이더 UI
    public GameObject mission22Special;//mission2-2 클리어 시 mission21Zone의 위치에 활성화 되는 특별 UI 

    void Start()
    {
        mission22Zone.SetActive(false); //시작 시 mission2-2의 수행존은 비활성화
        Invoke("mission22Activate", 12); //mission2-2은 시작 후 12초 뒤 mission22Activate() 메서드로 실행 
        mission22Special.SetActive(false); //시작 시 mission2-2의 특별 UI는 비활성화
    }

    void Update()
    {

    }

    void mission22Activate()
    {
        mission22Zone.SetActive(true); //mission22Activate 시 mission22Zone이 활성화 되며 mission2-2을 수행할 수 있음
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") //mission22Zone에 Player의 tag를 가진 게임오브젝트가 충돌 유지 시
        {
            GameObject director = GameObject.Find("GameDirector2"); //GameDirector2 게임오브젝트를 찾고
            director.GetComponent<GameDirector2>().IncreaseSlider22(); //GameDirector 컴포넌트의 IncreaseSlider22() 메서드 실행
        }
    }

    public void mission22Clear()
    {
        mission22Zone.SetActive(false); //mission2-2이 클리어 된다면 mission22Zone은 비활성화
        mission22Slider.SetActive(false); //mission2-2이 클리어 된다면 mission22Slider는 비활성화
        mission22Special.SetActive(true); //특별UI를 활성화
        //Invoke("LoadStage2", 9);
    }

    /*
    void LoadStage2()
    {
        SceneManager.LoadScene("Stage2");
    }
    */
}
