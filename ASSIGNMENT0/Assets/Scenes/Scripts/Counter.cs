using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.Events;

public class Counter : MonoBehaviour
{

	public int Value = 3, MinValue = 0;
	public float WaitTime = 1;

	public UnityEvent OnCountEvent, OnEndEvent;

	public void StartCounter()
	{
		StartCoroutine(RunCounter());
	}
	
	private IEnumerator RunCounter () { 
		
		var waitObject = new WaitForSeconds(WaitTime);
		
		while (true)
		{ 
			yield return new WaitForSeconds(WaitTime);
			print(Value > MinValue);
			Value--;
		}

		yield return waitObject; 
		OnEndEvent.Invoke(); 
	}
	

}
