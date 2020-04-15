using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnUnits : MonoBehaviour
{

    public GameObject spawnUnit;
    public GameObject spawnHex;
    public Vector3 HexCoordinates;
    public bool hexMapCreated;
    public bool isCreated;
    public Vector3 autobus;
    public int spawnednumber;
    public GameObject[] spawnUnits = new GameObject[2];
    public GameObject unitToSpawn;
    private int hexHeight;
  
    


    void Start()
    {
    hexHeight = 0;
    spawnednumber = 9;
    spawnUnits = new GameObject[spawnednumber];

    

   
	}

    void Update()
    {

   
	}


    
    public void Spawn()

        { 
        Debug.Log("I am starting the void");
        
        for(int i=0; i < spawnednumber; i++)
                {
                    spawnUnits[i] = unitToSpawn;
                    hexHeight = hexHeight +1;
                    spawnHex = GameObject.Find("/HexMap/Hex 0 "+hexHeight);
                    Instantiate(spawnUnit, new Vector3 (spawnHex.transform.position.x, spawnHex.transform.position.y +0.5f, spawnHex.transform.position.z), Quaternion.Euler(autobus.x, autobus.y, autobus.z));
                    isCreated = true;
                    spawnUnit.name = "Unit" +hexHeight;
	            }
                
		}
    }