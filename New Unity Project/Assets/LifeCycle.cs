using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour {
    // 게임 로직
    void Update () { // 게임 로직 업데이트 => 환경에 따라 실행 주기가 달라질 수 있음.
        if (Input.anyKeyDown) {
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        }

        if (Input.GetButton("Horizontal")) { // Horizontal -> 좌우 방향키, a, d
            // GetAxis -> 가중치 있음.
            // GetAxisRaw -> -1 왼쪽, 1 오른쪽, 0 가운데
            Debug.Log("횡 이동 중..." + Input.GetAxisRaw("Horizontal"));
        }

        if (Input.GetButton("Vertical")) { // Vertical -> 상하 방향키, w, s
            Debug.Log("종 이동 중..." + Input.GetAxisRaw("Vertical"));
        }
    }
}