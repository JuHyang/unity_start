using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour {
    // 게임 로직
    void Update () { // 게임 로직 업데이트 => 환경에 따라 실행 주기가 달라질 수 있음.
        if (Input.anyKeyDown) {
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        }

        if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("아이템을 구입하였습니다.");
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            Debug.Log("왼쪽으로 이동 중");
        }

        if (Input.GetKeyUp(KeyCode.RightArrow)) {
            Debug.Log("오른쪽 이동을 멈추었습니다.");
        }
    }
}