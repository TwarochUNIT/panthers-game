using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlane : MonoBehaviour
{
    public float movementSpeed;
    public Vector3 originalPos;
    public Vector3 currentPos;
    public GameObject plane;

    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.position;
        InvokeRepeating("Reset", 4.0f, 4.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right* Time.deltaTime * movementSpeed;

    }

    void Reset()
    {
        currentPos = originalPos;
        transform.position = originalPos;
	}
}
