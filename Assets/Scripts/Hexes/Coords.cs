using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coords : MonoBehaviour
{
    public GameObject myPrefab;
    // Start is called before the first frame update
    private void PrintName (GameObject go)
    {
            print(go.name);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //Debug.Log("Pressed Left Button");
        if (Input.GetMouseButtonDown(0)){
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 100.0f))
            {
            if (hit.transform != null)
                {
                    //PrintName(hit.transform.gameObject);
                    //Debug.Log("klikol som jak kkt, sem chcem volaco");
                }
            }
        }
    }
}
