using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

public GameObject pro,cpy1,cpy2,cpy3;
	
	
	void Update () 
	{
		if(Input.GetKeyDown("down"))
		{
			if(pro.transform.position==cpy1.transform.position||pro.transform.position==cpy2.transform.position)
			{	
				pro.transform.position=cpy1.transform.position;
			}
			else
			{
				pro.transform.position=cpy2.transform.position;
			}
		}

		if(Input.GetKeyDown("up"))
		{
			if(pro.transform.position==cpy3.transform.position||pro.transform.position==cpy2.transform.position)
			{	
				pro.transform.position=cpy3.transform.position;
			}
			else 
			{
				pro.transform.position=cpy2.transform.position;
			}
		}
	}
}
