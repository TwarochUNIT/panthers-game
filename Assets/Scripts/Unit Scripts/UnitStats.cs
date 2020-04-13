using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitStats : MonoBehaviour
{
    public int FrontArmor;
    public int BackArmor;
    public int LeftArmor;
    public int RightArmor;
    public int MainAmmo;
    public int SecondaryAmmo;
    public int Movement;
    public bool isUnit;


    // Start is called before the first frame update
    void Start()
    {
        isUnit = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
