using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodmove : MonoBehaviour 
{
public float objspeed=4;

void Update()
{
	this.transform.Translate(Vector3.left*objspeed*Time.deltaTime);
}

}
