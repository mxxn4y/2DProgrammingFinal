using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Sprite[] HeartSprites; //플레이어의 체력에 따라 변경될 Sprite 배열
    public Image HeartUI; //플레이어 체력을 나타내는 UI이미지를 참조하는 Image
    private Player player; //Player 클래스 참조 변수

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        //Player 태그를 가진 게임오브젝트를 찾고 Player 컴포넌트를 가져와서 player에 할당
	}
    
    
    void Update()
    {
        HeartUI.sprite = HeartSprites[player.currentHealth];
        //HeartUI의 sprite를 Sprite배열에서 player의 현재 체력에 해당하는 sprite로 설정
    }
}
