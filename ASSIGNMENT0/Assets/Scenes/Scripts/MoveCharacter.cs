using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveCharacter : MonoBehaviour
{
	public UnityEvent OnGrounded, OffGrounded;

	public MoveBase CharacterMover;
	
	private CharacterController _controller;
	private Vector3 position;
	
	private void Start()
	{
		_controller = GetComponent<CharacterController>();
	}

	void Update ()
	{
		if (_controller.isGrounded)
		{
			OnGrounded.Invoke();
			
		}
		else
		{
			OffGrounded.Invoke();
		}

		CharacterMover.Move(_controller);

		


	}
}
