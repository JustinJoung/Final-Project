﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drug : MonoBehaviour {
    public float speed = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0,0,50* Time.deltaTime);
	}
}
