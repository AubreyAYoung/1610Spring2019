using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSingleJump : MoveBase
{
   

    public override void Move(CharacterController controller)
    {
        if (_controller.isGrounded && Input.GetButton("Jump"))
        {
            position.y = JumpForce * Time.deltaTime;
		
        }
		
        position.y += Gravity*Time.deltaTime; 
        position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        controller.Move(position);
    }

}
