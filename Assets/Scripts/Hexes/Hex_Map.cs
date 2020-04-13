using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hex_Map : MonoBehaviour {

public int nextNameNumber = 0;
public GameObject selectedUnit;

//Mesh meshToCollide;

    // Use this for initialization
    void Start() {
        GenerateMap();
    }

    public GameObject HexPrefab;
    public LayerMask Terrainlayer;

    public int Cost;
    public Material[] HexMaterials;
       
     public void GenerateMap()
      {
      for (int column = 0; column < 100; column++)
      {
            for (int row = 0; row < 60; row++)
            {
                //instantiate a Hex
                Hex h = new Hex( column, row );

                GameObject hexGO = (GameObject)Instantiate(
                HexPrefab, 
                h.Position(),
                Quaternion.identity,
                this.transform
                );

                MeshRenderer mr = hexGO.GetComponentInChildren<MeshRenderer>();
                mr.material = HexMaterials[ Random.Range(0, HexMaterials.Length) ];
                hexGO.GetComponentInChildren<TextMesh>().text = string.Format("{0},{1}", column, row);
                hexGO.GetComponentInChildren<TerrainData>();
                hexGO.name = "Hex "+column+" "+row;
                nextNameNumber++;
              
                      //adding colliders          
                hexGO.AddComponent<BoxCollider>();
                hexGO.GetComponent<BoxCollider>();
                hexGO.GetComponent<BoxCollider>().isTrigger = true;
                hexGO.GetComponentInChildren<BoxCollider>().size = new Vector3 (2, 0.3f, 2);
                        
               
               
               hexGO.layer = 9;
                //Debug.Log(mr.material);

               
                   

               
            }
      }
    }
}