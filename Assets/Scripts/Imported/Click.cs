using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    [SerializeField]
    private LayerMask clickablesLayer;
    [SerializeField]
    private LayerMask terrainLayer;
    [SerializeField]
    public string selectedname;
    [SerializeField]
    public GameObject selectedObject;
    [SerializeField]
    public GameObject selectionIndicator;
    [SerializeField]
    public GameObject moveIndicator;
    [SerializeField]
    public Vector3 selectedObjectCoords;
    [SerializeField]
    public Vector3 markerCoords;
    [SerializeField]
    public Vector3 moveHexCoords;
    [SerializeField]
    public Animation anim;
    [SerializeField]
    public float angle = 0;
    [SerializeField]
    public float angleBetween;
    [SerializeField]
    public bool unitSelected;
    [SerializeField]
    public GameObject parent;




    void Start ()
    {
        unitSelected = false;
        selectionIndicator.transform.position = new Vector3 (-1, -1, -1);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            RaycastHit rayHit;

                if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit, Mathf.Infinity, clickablesLayer))
                    {
                        ClickOn clickOnScript = rayHit.collider.GetComponent<ClickOn>();
                        clickOnScript.selected = !clickOnScript.selected;
                        selectedname = rayHit.collider.gameObject.name;
                        Debug.Log(rayHit.collider.gameObject.name);
                        
                        if(selectedname != null)
                        {
                            selectedObject = GameObject.Find(selectedname);
                            Debug.Log("Selected Object Position is " + selectedObject.transform.position);
                            selectedObjectCoords = selectedObject.transform.position;
                            selectionIndicator.transform.position = new Vector3(selectedObjectCoords.x, selectedObjectCoords.y - 0.2f, selectedObjectCoords.z);
                            unitSelected = true;

                            //can't find the gameobject that is the parrent of the selected object for some reason
                            // = selectedObject.parent.gameObject;
						}
                    }
        }
        if (Input.GetMouseButtonDown(1) && unitSelected == true)
            {
                //if (unitSelected = true)
                
                RaycastHit rayHit;
                 if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit, Mathf.Infinity, terrainLayer))
                    {
                        
                        Debug.Log(rayHit.collider.gameObject.name);
                        moveHexCoords = new Vector3(rayHit.collider.transform.position.x, rayHit.collider.transform.position.y, rayHit.collider.transform.position.z);
                        moveIndicator.transform.position = new Vector3(moveHexCoords.x, moveHexCoords.y + 0.5f, moveHexCoords.z);
                        //draw line between selected object and marker
                       Debug.DrawLine (moveIndicator.transform.position, selectedObject.transform.position, Color.red, 2.5f); 

                        //
                        Vector3 targetDir = moveIndicator.transform.position - selectedObject.transform.position;
                        float angle = Vector3.Angle(moveIndicator.transform.position, selectedObject.transform.position);
                        angleBetween = angle;
                        selectedObject.transform.Rotate(0.0f, 45.0f, 0.0f, Space.World);


                        
                        //Debug.DrawRay(selectedObject.transform.position.y, moveIndicator.transform.position.y, Color.red);
					}
                //}
		    }
            
        }
}
