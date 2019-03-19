using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.Events; 

public class Doggo1 : Mammal1 
{

    public int Hunger = 50;
    public float HungerIncrease = 0.5f;
	
    // Use this for initialization
    void Start () 
    {
        print("Hello, World"); 
        GetComponent<SpriteRenderer>().color = SkinColor; 		
    }
	
    // Update is called once per frame
    void Update ()
    {
        transform.Rotate(0,1,0);	
    }
    
}
