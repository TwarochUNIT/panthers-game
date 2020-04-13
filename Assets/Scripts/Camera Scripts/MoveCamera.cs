using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour


{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    
    {
        float edgeSize = 10f;
        if (Input.mousePosition.x > Screen.width - edgeSize || (Input.GetKey(KeyCode.D)))
            {
                Camera.current.transform.Translate(new Vector3(4.0f * Time.deltaTime, 0.0f, 0.0f));  
                //Debug.Log("moving x right");
            }
        if (Input.mousePosition.x < edgeSize || (Input.GetKey(KeyCode.A)))
            {
                Camera.current.transform.Translate(new Vector3(-4.0f * Time.deltaTime, 0.0f, 0.0f));  
                //Debug.Log("moving x left");
            }
        if (Input.mousePosition.y > Screen.height - edgeSize || (Input.GetKey(KeyCode.W)))
            {
                Camera.current.transform.Translate(new Vector3(0.0f, 4.0f * Time.deltaTime, 0.0f));  
                 //Debug.Log("moving y up");
            }
        if (Input.mousePosition.y < edgeSize || (Input.GetKey(KeyCode.S)))
            {
                Camera.current.transform.Translate(new Vector3(0.0f, -4.0f * Time.deltaTime, 0.0f));  
                 //Debug.Log("moving y down");
            }
    }
}
