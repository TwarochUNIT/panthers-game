using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitPosition : MonoBehaviour
{
    public GameObject HexPosition;
    public Collider[] colliders;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        colliders = Physics.OverlapSphere(transform.position, 0.3f);

        if (colliders[0].name != this.gameObject.name)
        {

         if (colliders.Length > 0)
         {

                    Debug.Log("Standing on " + colliders[0].name);
                    HexPosition = colliders[0].gameObject;
         }
         else
         {
             Debug.Log("I'm outside the weather zone");
         }
         }
    }
}
