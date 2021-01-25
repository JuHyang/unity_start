using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour {
    // 게임 로직
    void Update () { // 게임 로직 업데이트 => 환경에 따라 실행 주기가 달라질 수 있음.
        if (Input.anyKeyDown) {
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        }

        if (Input.GetButtonDown("Jump")) { 
            Debug.Log("점프!");
        }

        if (Input.GetButton("Jump")) {
            Debug.Log("점프 모으는 중 ...");
        }

        if (Input.GetButtonUp("Jump")) {
            Debug.Log("슈퍼 점프 !!");
        }
    }
}