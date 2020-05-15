using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {

	public AudioClip eat;
	public AudioClip die;
    public AudioSource sources;
	public void mus()
	{
		sources.clip=eat;
		sources.Play();
	}
	public void mus1()
	{
		sources.clip=die;
		sources.Play();
	}
}
