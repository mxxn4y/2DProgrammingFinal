using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue; // 대화 내용을 저장하는 변수
    public Sprite cg; // 대화에 따른 캐릭터 CG 이미지를 저장하는 변수
}

public class TalkScripts : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_StandingCG; // 대화 시 캐릭터 CG를 표시할 스프라이트 렌더러 컴포넌트
    [SerializeField] private SpriteRenderer sprite_DialogueBox; // 대화 내용을 표시할 대화 상자의 스프라이트 렌더러 컴포넌트
    [SerializeField] private Text txt_Dialogue; // 대화 내용을 표시할 텍스트 UI 컴포넌트

    private bool isDialogue = false; // 대화 중인지 여부를 나타내는 변수

    private int count = 0; // 대화 카운트 변수

    [SerializeField] private Dialogue[] dialogue; // 대화 정보를 담은 Dialogue 배열

    public void ShowDialogue()
    {
        OnOff(true); // 대화 상자, 캐릭터 CG, 대화 텍스트 UI를 활성화
        count = 0; // 대화 카운트 초기화
        NextDialogue(); // 다음 대화로 넘어감
    }

    private void OnOff(bool _flag)
    {
        sprite_DialogueBox.gameObject.SetActive(_flag); // 대화 상자 활성화 여부 설정
        sprite_StandingCG.gameObject.SetActive(_flag); // 캐릭터 CG 활성화 여부 설정
        txt_Dialogue.gameObject.SetActive(_flag); // 대화 텍스트 UI 활성화 여부 설정
        isDialogue = _flag; // 대화 중인지 여부 설정
    }

    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue; // 현재 대화 내용을 텍스트 UI에 표시
        sprite_StandingCG.sprite = dialogue[count].cg; // 현재 대화에 해당하는 캐릭터 CG 이미지 표시
        count++; // 대화 카운트 증가
    }

    void Start()
    {

    }

    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetKeyDown(KeyCode.Return)) // Enter 키를 누르면
            {
                if (count < dialogue.Length) // 대화가 더 남았을 경우
                {
                    NextDialogue(); // 다음 대화로 넘어감
                }
                else // 대화가 모두 끝난 경우
                {
                    OnOff(false); // 대화 상자, 캐릭터 CG, 대화 텍스트 UI를 비활성화
                }
            }
        }
    }

}
