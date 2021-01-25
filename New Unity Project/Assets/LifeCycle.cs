using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour {
    // 게임 로직
    void Update () { // 게임 로직 업데이트 => 환경에 따라 실행 주기가 달라질 수 있음.
        if (Input.anyKeyDown) {
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        }

        if (Input.GetMouseButtonDown(0)) { // 0은 좌클릭, 1은 우클릭
            Debug.Log("미사일 발사!");
        }

        if (Input.GetMouseButton(0)) {
            Debug.Log("미사일 모으는 중 ...");
        }

        if (Input.GetMouseButtonUp(0)) {
            Debug.Log("슈퍼 미사일 발사 !!");
        }
    }
}