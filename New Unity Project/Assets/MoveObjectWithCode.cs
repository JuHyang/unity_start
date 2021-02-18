using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectWithCode : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);

    private void Update() {
        // 1. MoveTowards
        // transform.position = Vector3.MoveTowards(transform.position, target, 0.1f);

        // 2. SmoothDamp
        // Vector3 velo = Vector3.zero;

        // transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.2f);

        // 3. Lerp (선형 보간)
        // transform.position = Vector3.Lerp(transform.position, target, 0.1f);

        // 4. SLerp (구면 선형 보간)
        transform.position = Vector3.Slerp(transform.position, target, 0.05f);
    }
}
