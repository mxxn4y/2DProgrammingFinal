using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mission1 : MonoBehaviour
{

    public GameObject mission1Zone; //mission1을 수행할 수 있는 게임오브젝트
    public GameObject mission1Slider; //mission1의 진척도를 표시하는 슬라이더 UI
    public GameObject mission1Coin; //mission1 클리어 시 왼쪽 상단에 표시되는 코인 UI
    public GameObject mission1Special; //mission1 클리어 시 mission1Zone의 위치에 활성화 되는 특별UI
    //public bool isMission1Clear = false;

    void Start()
    {
        mission1Special.SetActive(false); //시작 시 mission1의 특별 UI는 비활성화
        mission1Zone.SetActive(false); //시작 시 mission1 수행존은 비활성화
        Invoke("mission1Activate", 10); //시작 후 10초 뒤 mission1 활성화하는 mission1Active() 메서드 실행
        mission1Coin.SetActive(false); //시작 시 mission1의 코인 UI는 비활성화
    }

    void Update()
    {

    }

    void mission1Activate()
    {
        mission1Zone.SetActive(true); //mission1Active 시 mission1Zone이 활성화 되며 mission1을 수행할 수 있음
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player") //mission1Zone에 Player의 tag를 가진 게임오브젝트가 충돌 유지 시
        {
            GameObject director = GameObject.Find("GameDirector"); //GameDirector 게임오브젝트를 찾고
            director.GetComponent<GameDirector>().IncreaseSlider(); //GameDirector 컴포넌트의 IncreaseSlider() 메서드 실행
        }
    }

    public void mission1Clear()
    {
        mission1Zone.SetActive(false); //mission1이 클리어 된다면 mission1Zone은 비활성화
        mission1Slider.SetActive(false); //mission1Slider는 비활성화
        mission1Coin.SetActive(true); //mission1Coin을 활성화
        mission1Special.SetActive(true); //특별UI를 활성화
        Invoke("LoadClear1", 8); //8초 뒤 LoadClear1() 메서드를 실행
    }

    void LoadClear1()
    {
        SceneManager.LoadScene("Clear1"); //Clear1 씬을 로드
    }
}
