using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUnits : MonoBehaviour
{

    public GameObject spawnUnit;
    public GameObject spawnHex;
    public Vector3 HexCoordinates;
    public bool hexMapCreated;
    public bool isCreated;
    public Vector3 autobus;


    void Start()
    {
    autobus.x = -90;
    autobus.y = 0;
    autobus.z = 180;
    
	}

    void Update()
    {

    spawnHex = GameObject.Find("/HexMap/Hex 0 1");
    HexCoordinates = spawnHex.transform.position;
    if(spawnHex != null)
        {
            hexMapCreated = true;
            if(isCreated != true)
            {            
            Instantiate(spawnUnit, new Vector3 (spawnHex.transform.position.x, spawnHex.transform.position.y +0.5f, spawnHex.transform.position.z), Quaternion.Euler(autobus.x, autobus.y, autobus.z));
            isCreated = true;
            spawnUnit.transform.rotation = Quaternion.Euler(autobus.x, autobus.y, autobus.z);        
            }
      
		}
	}


    // Start is called before the first frame update
    void Spawn()

        {
               
                //Instantiate(spawnUnit, spawnHex.transform.position, autobus);
                
		}
    }