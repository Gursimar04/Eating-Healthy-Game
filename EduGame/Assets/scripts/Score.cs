using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public float StartScr;
	public Text soring;	

	
	// Update is called once per frame
	void Update ()
	{	
	StartScr=FindObjectOfType<val>().sc;
		string score =StartScr.ToString();
		soring.text ="Score:"+score;
	}
}
