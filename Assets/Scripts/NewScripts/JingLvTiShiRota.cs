﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JingLvTiShiRota : MonoBehaviour {
    public float speed_rota;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(0, speed_rota* Time.deltaTime, 0);
		
	}
}
