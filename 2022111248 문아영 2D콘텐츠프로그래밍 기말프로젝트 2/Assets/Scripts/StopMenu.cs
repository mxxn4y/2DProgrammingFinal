using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopMenu : MonoBehaviour
{
    //스테이지 화면에서 esc키를 눌렀을때 나오는 팝업 메뉴의 버튼 상호작용을 위한 스크립트

    public GameObject stopButton; //게임오브젝트 참조 변수 stopButton

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel")) //esc버튼을 눌렀을때
        {
            if (stopButton.activeSelf) //stopButton이 활성화 상태라면
            {
                stopButton.SetActive(false); //stopButton을 비활성화 (켜져 있는 상태에서 비활성화)
            }
            else //활성화 상태가 아니라면
            {
                stopButton.SetActive(true); //stopButton을 활성화
            }
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //현재 씬 다시불러오기
    }

    public void Main()
    {
        SceneManager.LoadScene("Main"); //Main씬 불러오기
    }
}
