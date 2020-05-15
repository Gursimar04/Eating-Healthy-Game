using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject die1,die2,die3,die4,die5,die6,die7,die8,die9,die10,pos1,pos2,pos3;
	public float timedelay=2;
	public float nextTimeSpawn;
		   int whichfood,whichpos;
	
	Vector3 temp;  
	
	void Update () 
	{
		whichfood=Random.Range(1,11);
		whichpos=Random.Range(1,4);
		
		
		switch(whichpos)
		{
			case 1:temp= pos1.transform.position;
										break;

			case 2:temp= pos2.transform.position;
										break;

			case 3:temp= pos3.transform.position;
										break;
		}


		if(checkspawn())
		{
			switch(whichfood)
			{
				case 1:Spawn1();
							break;
				
				case 2:Spawn2();
							break;
				
				case 3:Spawn3();
							break;

				case 4:Spawn4();
							break;

				case 5:Spawn5();
							break;

				case 6:Spawn6();
							break;

				case 7:Spawn7();
							break;

				case 8:Spawn8();
							break;

				case 9:Spawn9();
							break;

				case 10:Spawn10();
							break;
			}
			
		}
		
	}
	
	void Spawn1()
	{
		nextTimeSpawn=Time.time+timedelay;
		Instantiate(die1,temp,transform.rotation);
	
	}
	void Spawn2()
	{
		nextTimeSpawn=Time.time+timedelay;
		Instantiate(die2,temp,transform.rotation);
	
	}
	void Spawn3()
	{
		nextTimeSpawn=Time.time+timedelay;
		Instantiate(die3,temp,transform.rotation);
	
	}
	void Spawn4()
	{
		nextTimeSpawn=Time.time+timedelay;
		Instantiate(die4,temp,transform.rotation);
	}
	void Spawn5()
	{
		nextTimeSpawn=Time.time+timedelay;
		Instantiate(die5,temp,transform.rotation);
	
	}
	void Spawn6()
	{
		nextTimeSpawn=Time.time+timedelay;
		Instantiate(die6,temp,transform.rotation);
	}
	void Spawn7()
	{
		nextTimeSpawn=Time.time+timedelay;
		Instantiate(die7,temp,transform.rotation);
	
	}
	void Spawn8()
	{
		nextTimeSpawn=Time.time+timedelay;
		Instantiate(die8,temp,transform.rotation);
	
	}
	void Spawn9()
	{
		nextTimeSpawn=Time.time+timedelay;
		Instantiate(die9,temp,transform.rotation);
	
	}
	void Spawn10()
	{
		nextTimeSpawn=Time.time+timedelay;
		Instantiate(die10,temp,transform.rotation);
	
	}

	public bool checkspawn()
	{
		return Time.time>=nextTimeSpawn;
	}

}
