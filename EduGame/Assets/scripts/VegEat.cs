using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VegEat : MonoBehaviour {

void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == "char")
		{
          Destroy(gameObject);

		   FindObjectOfType<points>().StartScore+=50;
		   FindObjectOfType<Sound>().mus();

		}
		 
	}
}
