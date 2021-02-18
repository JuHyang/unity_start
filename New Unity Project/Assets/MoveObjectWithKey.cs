using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private void Start() {
        // 기본 초기화 되어 있는 변수 :: transform        
        Vector3 vec = new Vector3(5, 0, 0);
        transform.Translate(vec);
    }

    private void Update() {
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.Translate(vec);
    }
}
