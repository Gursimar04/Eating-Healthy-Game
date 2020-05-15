using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public float targetTime = 60.0f;
	public Text timerText;

	
 
	void Update()
	{
		targetTime -= Time.deltaTime;
		string minutes =((int)targetTime/60).ToString();
		string seconds =(targetTime%60).ToString();
		timerText.text =minutes+":"+seconds;
	
		if (targetTime <= 0.0f)
			{
				timerEnded();
			}
    }
 
	void timerEnded()
	{
		SceneManager.LoadScene(2);
	}

}
