using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin2 : PowerUpBase 
{

    public float Coin2Value = 3f;
	
    public void OnCoin2Pickup (float AddCoin2Value)
    {
        Coin2Value += AddCoin2Value;
    }

    
}
