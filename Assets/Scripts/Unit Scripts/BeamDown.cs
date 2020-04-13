using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamDown : MonoBehaviour
{
    public Vector3 direction = -Vector3.up;
    public float Maxdistance = 10;
    public RaycastHit hit;
    public LayerMask layermask;
    public GameObject PositionHex;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.DrawRay(transform.position, direction * 10, Color.red, 0);
        //enable to see the ray hitting the terrain

        if(Physics.Raycast(transform.position, direction, out hit, Maxdistance, layermask))
        {
            //print(hit.collider.gameObject.name);
            PositionHex = hit.collider.gameObject;
            transform.position = new Vector3(PositionHex.transform.position.x, PositionHex.transform.position.y +0.5f, PositionHex.transform.position.z);
        }
    }
}
