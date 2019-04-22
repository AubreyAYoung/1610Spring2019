using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : PowerUpBase 
{

	public float AmmoValue = 3f;
	
	public void OnAmmoPickup (float AddAmmoValue)
	{
		Value += AddAmmoValue;
	}
	
}
