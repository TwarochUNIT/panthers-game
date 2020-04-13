using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveSelected : MonoBehaviour
{
    public float Movement = 100f;
    public Vector3 position;
    public GameObject selectedUnit;
    public GameObject defselection;
    public Vector3 mousePosition;

    //public Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Click>().selectedname != null)
         {
       selectedUnit = GameObject.Find(GetComponent<Click>().selectedname);
       //position = selectedUnit.transform.position;
       selectedUnit.transform.Rotate(new Vector3 (0f, 1f, 0f));
    }
            if (Input.GetMouseButtonDown(1))
            {   
                //Grab the current mouse position on the screen
                mousePosition = GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, Input.mousePosition.z));
                Debug.Log(mousePosition.x);
                Debug.DrawLine(Vector3.zero, new Vector3(5, 0, 0), Color.white, 2.5f);
            }
    }
}
