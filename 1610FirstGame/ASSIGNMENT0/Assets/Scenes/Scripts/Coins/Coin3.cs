using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin3 : PowerUpBase
{
	public float Coin3Value = 1f;
	
	public void OnCoin3Pickup (float AddCoin3Value)
	{
		Value += AddCoin3Value;
	}

}
