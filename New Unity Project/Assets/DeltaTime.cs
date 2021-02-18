using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal")  * Time.deltaTime, Input.GetAxisRaw("vertical") * Time.deltaTime);
        transform.Translate(vec);
    }
}
