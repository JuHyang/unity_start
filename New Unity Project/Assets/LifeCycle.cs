using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour {
    
    private void Start() {
        // 기본 초기화 되어 있는 변수 :: transform        
        Vector3 vec = new Vector3(5, 0, 0);
        transform.Translate(vec);
    }

    private void Update() {
        Vector3 vec = new Vector3(0, 0.01f, 0);
        transform.Translate(vec);
    }
}