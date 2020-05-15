using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kil : MonoBehaviour {

	public GameObject h1,h2,h3,d1,d2,d3;
	public void kill() 
	{
	if(h3.activeSelf==true)
		  {
		  	  h3.SetActive(false);
			  d3.SetActive(true);
		  }
		  else if(h2.activeSelf==true)
		  {
		  	  h2.SetActive(false);
			  d2.SetActive(true);
		  }
		  else if(h1.activeSelf==true)
		  {
		  	  h1.SetActive(false);
			  d1.SetActive(true);
			  SceneManager.LoadScene(3);
		  }
		
	}
	
}
