using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Clear1ToStage1()
    {
        SceneManager.LoadScene("Stage1"); //Stage1을 클리어하기 위해 Stage1씬으로 이동
    }
    public void ToStage2Sc()
    {
        SceneManager.LoadScene("Stage2_Sc2"); //Stage1을 클리어하기 위해 Stage1씬으로 이동
    }
    public void Clear1ToStage2()
    {
        SceneManager.LoadScene("Stage2"); //Stage2를 클리어하기 위해 Stage1에서 Stage2씬으로 이동
    }
    public void Clear2ToStage3()
    {
        SceneManager.LoadScene("Stage3"); //Stage3를 클리어하기 위해 Stage2에서 Stage3씬으로 이동
    }
    public void ToStage3Sc()
    {
        SceneManager.LoadScene("Stage3_Sc2"); //Stage1을 클리어하기 위해 Stage1씬으로 이동
    }
    public void Clear3ToEnding()
    {
        SceneManager.LoadScene("Ending"); //Stage3를 클리어 하고 Stage3에서 Ending씬으로 이동
    }
}
