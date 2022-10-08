using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Run", fileName = "PlayerState_Run")]

public class PlayerState_Run : PlayerState
{
    [SerializeField] float runSpeed = 5f;
    [SerializeField] float acceration = 5f;


    public override void Enter()
    {
        animator.Play("HeroKnight_Run");
        Debug.Log("Now in Run State");
        currentSpeed = controller.playerSpeed;
    }

    public override void LogicUpdate()
    {
        if (!(Keyboard.current.aKey.isPressed || Keyboard.current.dKey.isPressed))
        {
            stateMachine.SwitchState(typeof(PlayerState_Idle));
        }
        if (Keyboard.current.wKey.isPressed)
        {
            stateMachine.SwitchState(typeof(PlayerState_Jump));
        }

        currentSpeed = Mathf.MoveTowards(currentSpeed,runSpeed,acceration*Time.deltaTime);
        
        if (Keyboard.current.wKey.isPressed && controller.IsGrounded)
        {
            stateMachine.SwitchState(typeof(PlayerState_Jump));
        }

        if (!controller.IsGrounded)
        {
            stateMachine.SwitchState(typeof(PlayerState_Fall));
        }
    }

    public override void PhysicUpdate()
    {
        controller.Move(currentSpeed);
    }
}


