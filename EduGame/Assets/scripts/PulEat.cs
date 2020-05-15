using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulEat : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == "char")
		{
          Destroy(gameObject);

		   FindObjectOfType<points>().StartScore+=20;
		   FindObjectOfType<Sound>().mus();

		}
		 
	}
}
