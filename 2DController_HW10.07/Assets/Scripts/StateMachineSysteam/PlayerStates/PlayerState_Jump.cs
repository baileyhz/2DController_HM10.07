using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Jump", fileName = "PlayerState_Jump")]

public class PlayerState_Jump : PlayerState
{
    [SerializeField] float jumpForce = 15f;
    [SerializeField] float jumpSpeed = 2f;

    public override void Enter()
    {
        animator.Play("HeroKnight_Jump");
        Debug.Log("Now in Jump State");
        controller.SetVelocityY(jumpForce);
    }

    public override void LogicUpdate()
    {
        if ((Input.GetKeyUp(KeyCode.W))||controller.IsFall)
        {
            stateMachine.SwitchState(typeof(PlayerState_Fall));

        }
        
    }

    public override void PhysicUpdate()
    {
        

        if (Keyboard.current.aKey.isPressed || Keyboard.current.dKey.isPressed)
            controller.Move(jumpSpeed);
    }

}
