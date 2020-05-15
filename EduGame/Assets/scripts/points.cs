using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour {
	public float StartScore = 0f;
	public Text scoring;	

	
	// Update is called once per frame
	void Update ()
	{
		string score =StartScore.ToString();
		scoring.text ="Score:"+score;
		FindObjectOfType<val>().scs();
	}
}
