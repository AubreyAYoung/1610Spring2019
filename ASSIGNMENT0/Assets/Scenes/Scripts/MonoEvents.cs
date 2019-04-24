using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.Events; 

public class MonoEvents : MonoBehaviour
{

	public UnityEvent StartEvent, EnableEvent, MouseDownEvent, UpdateEvent, OnTriggerEvent;
	
	void Start () 
	{
		StartEvent.Invoke();
	}

	private void OnEnable()
	{
		EnableEvent.Invoke();
	}

	private void OnTriggerEnter(Collider other)
	{
	OnTriggerEvent.Invoke();	}

	private void OnMouseDown()
	{
		MouseDownEvent.Invoke();
	}


	// Update is called once per frame
	void Update () 
	{
		UpdateEvent.Invoke();
	}
}
