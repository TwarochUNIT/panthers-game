using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{

    [SerializeField]
    private Material red;
    
    [SerializeField]
    private Material green;
    [SerializeField]
    public bool selected;
    
    

    private MeshRenderer myRend;

    // Start is called before the first frame update
    void Start()
    {
        myRend = GetComponent<MeshRenderer>();
        ClickMe();
    }

   public void ClickMe()
   {
       //myRend.material = green;
       

   }
}
