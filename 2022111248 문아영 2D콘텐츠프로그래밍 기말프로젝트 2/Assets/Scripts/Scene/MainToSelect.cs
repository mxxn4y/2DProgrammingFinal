using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainToSelect : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData) //UI요소가 클릭 되었을 때
    {
        SceneManager.LoadScene("StageSelect"); //StageSelect씬을 로드
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
