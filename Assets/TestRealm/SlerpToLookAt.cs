﻿using UnityEngine;
 
 public class SlerpToLookAt: MonoBehaviour
 {
    public Transform target;
     private void Update()
     {
      Vector3 direction = target.position - transform.position;
      Quaternion rotation = Quaternion.LookRotation(direction);
      transform.rotation = rotation;
  	 }
 }