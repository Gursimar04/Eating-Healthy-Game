using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ueat : MonoBehaviour 
{ 
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == "char")
		{
          Destroy(gameObject);

		   FindObjectOfType<kil>().kill();
		   FindObjectOfType<Sound>().mus1();
		    
		}
		 
	}
}
