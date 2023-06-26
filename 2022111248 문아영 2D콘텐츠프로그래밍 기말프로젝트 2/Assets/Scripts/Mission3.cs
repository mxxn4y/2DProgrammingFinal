using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mission3 : MonoBehaviour
{

    public GameObject mission3Zone; //mission3을 수행할 수 있는 게임오브젝트
    public GameObject mission3Slider; //mission3의 진척도를 표시하는 슬라이더 UI
    public GameObject mission3Coin; //mission3 클리어 시 왼쪽 상단에 표시되는 코인 UI
    public GameObject mission3Special; //mission3 클리어 시 mission3Zone의 위치에 활성화 되는 특별UI
    //public bool isMission3Clear = false;

    void Start()
    {
        mission3Special.SetActive(false); //시작 시 mission3의 특별 UI는 비활성화
        mission3Zone.SetActive(false); //시작 시 mission3의 수행존은 비활성화
        Invoke("mission3Activate", 3); //mission3은 시작 후 3초 뒤 mission3Activate() 메서드로 실행
        mission3Coin.SetActive(false); //시작 시 mission3의 코인 UI는 비활성화
    }

    void Update()
    {

    }

    void mission3Activate()
    {
        mission3Zone.SetActive(true); //mission3Active 시 mission3Zone이 활성화 되며 mission3을 수행할 수 있음
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") //mission3Zone에 Player의 tag를 가진 게임오브젝트가 충돌 유지 시
        {
            GameObject director = GameObject.Find("GameDirector3"); //GameDirector3 게임오브젝트를 찾고
            director.GetComponent<GameDirector3>().IncreaseSlider3(); //GameDirector3 컴포넌트의 IncreaseSlider3() 메서드 실행
        }
    }

    public void mission3Clear()
    {
        mission3Zone.SetActive(false); //mission3이 클리어 된다면 mission1Zone은 비활성화
        mission3Slider.SetActive(false); //mission3Slider는 비활성화
        mission3Coin.SetActive(true); //mission3Coin을 활성화
        mission3Special.SetActive(true); //특별UI를 활성화
    }
}
