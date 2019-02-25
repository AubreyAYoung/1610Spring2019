using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin1 : PowerUpBase
{

	public float Coin1Value = 5f;
	
	public void OnCoin1Pickup (float AddCoin1Value)
	{
		Value += AddCoin1Value;
	}
	
}
