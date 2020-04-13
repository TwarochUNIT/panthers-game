using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneArti : MonoBehaviour
{
    public GameObject Plane;
    public GameObject Camera;
    public GameObject ArtiButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void artillery()
    {
        
        Plane.transform.Translate(Vector3.right * Time.deltaTime * 30);
        Camera.transform.Translate(Vector3.right * Time.deltaTime * 30);
    }
}
