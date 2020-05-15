using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {

	// Use this for initialization
	public void OnClick()
	{
		SceneManager.LoadScene(5);
	}
	public void OnClick1()
	{
		SceneManager.LoadScene(0);
	}
		public void OnClick2()
	{
		SceneManager.LoadScene(1);
	}
		public void OnClick3()
	{
		SceneManager.LoadScene(4);
	}
		public void OnClick4()
	{
		SceneManager.LoadScene(6);
	}
}
