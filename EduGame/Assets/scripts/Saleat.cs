﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saleat : MonoBehaviour {


void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == "char")
		{
          Destroy(gameObject);

		   FindObjectOfType<points>().StartScore+=30;
		   FindObjectOfType<Sound>().mus();
		   

		}
		 
	}
}
