using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Fall", fileName = "PlayerState_Fall")]
public class PlayerState_Fall : PlayerState
{
    [SerializeField] float fallSpeed=2f;
    [SerializeField] AnimationCurve speeedCurve;

    public override void Enter()
    {
        animator.Play("HeroKnight_Fall");
        Debug.Log("Now in Fall State");
    }
    public override void LogicUpdate()
    {

        if (controller.IsGrounded)
        {
            stateMachine.SwitchState(typeof(PalyerState_Land));
        }
    }

    public override void PhysicUpdate()
    {
        controller.SetVelocityY(speeedCurve.Evaluate(7f));
        
        if (Keyboard.current.aKey.isPressed || Keyboard.current.dKey.isPressed)
            controller.Move(fallSpeed);
    }
}
