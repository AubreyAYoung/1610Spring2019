﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doggo : Animal
{

	// Use this for initialization
	void Start () 
{
   print("Hello, World"); 
         GetComponent<SpriteRenderer>().color = SkinColor; 		
	}
	
	// Update is called once per frame
	void Update ()
 {
	transform.Rotate(0,1,0);	
	}
}
