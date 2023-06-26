using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SelectToStage1 : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData) //UI요소가 클릭 되었을 때
    {
        SceneManager.LoadScene("Stage1_Sc"); //Stage1_Sc씬을 로드
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
