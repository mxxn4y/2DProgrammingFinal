using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SelectToStage3 : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData) //UI요소가 클릭 되었을 때
    {
        SceneManager.LoadScene("Stage3_Sc2"); //Stage3_Sc2씬을 로드
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
