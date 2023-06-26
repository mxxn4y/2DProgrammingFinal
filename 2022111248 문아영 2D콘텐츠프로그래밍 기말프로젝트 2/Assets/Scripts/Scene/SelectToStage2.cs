using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SelectToStage2 : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData) //UI요소가 클릭 되었을 때
    {
        SceneManager.LoadScene("Stage2_Sc2"); //Stage2_Sc2를 로드
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
