using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowScore : MonoBehaviour {

	void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
	}
}
