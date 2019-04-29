using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greetings : MonoBehaviour
{
//got this from a tutorial
	public int GreetingNumber = 5;

	void Greet()
	{
		switch (GreetingNumber)
		{
			
			case 5:
				print("Henlo");
				break;
			case 4:
				print("Welcome to Little Greek World");
				break; 
			case 3:
				print("Press start to begin");
				break; 
			case 2:
				print("Press anywhere to begin");
				break; 
			case 1:
				print("oof sorry this is print statement");
				break;
			default:
				print ("Welcome Player");
				break;
			
		}
		
		
	}

}
