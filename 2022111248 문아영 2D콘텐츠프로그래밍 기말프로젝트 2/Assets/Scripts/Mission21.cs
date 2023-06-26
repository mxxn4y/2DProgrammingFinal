using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mission21 : MonoBehaviour
{

    public GameObject mission21Zone; //mission2-1을 수행할 수 있는 게임오브젝트
    public GameObject mission21Slider; //mission2-1의 진척도를 표시하는 슬라이더 UI
    public GameObject mission21Special; //mission2-1 클리어 시 mission21Zone의 위치에 활성화 되는 특별 UI 

    void Start()
    {
        mission21Zone.SetActive(false); //시작 시 mission2-1의 수행존은 비활성화
        Invoke("mission21Activate", 5); //mission2-1은 시작 후 5초 뒤 mission21Activate() 메서드로 실행
        mission21Special.SetActive(false); //시작 시 mission2-1의 특별 UI는 비활성화
    }

    void Update()
    {

    }

    void mission21Activate()
    {
        mission21Zone.SetActive(true); //mission21Activate 시 mission21Zone이 활성화 되며 mission2-1을 수행할 수 있음
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") //mission21Zone에 Player의 tag를 가진 게임오브젝트가 충돌 유지 시 
        {
            GameObject director = GameObject.Find("GameDirector2"); //GameDirector2 게임오브젝트를 찾고
            director.GetComponent<GameDirector2>().IncreaseSlider21(); //GameDirector 컴포넌트의 IncreaseSlider21() 메서드 실행
        }
    }

    public void mission21Clear()
    {
        mission21Zone.SetActive(false); //mission2-1이 클리어 된다면 mission21Zone은 비활성화
        mission21Slider.SetActive(false); //mission2-1이 클리어 된다면 mission21Slider는 비활성화
        mission21Special.SetActive(true); //특별UI를 활성화
        //Invoke("LoadStage2", 9);
    }

    /*
    void LoadStage2()
    {
        SceneManager.LoadScene("Stage2");
    }
    */
}
