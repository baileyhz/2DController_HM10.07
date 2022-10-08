using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Land", fileName = "PlayerState_Land")]
public class PalyerState_Land : PlayerState
{
    public override void Enter()
    {
        Debug.Log("Now in Land State");
    }
    public override void LogicUpdate()
    {

        if (Keyboard.current.aKey.isPressed || Keyboard.current.dKey.isPressed)
        {
            stateMachine.SwitchState(typeof(PlayerState_Run));
        }

        if (Keyboard.current.wKey.isPressed)
        {
            stateMachine.SwitchState(typeof(PlayerState_Jump));
        }
        if(!(Keyboard.current.wKey.isPressed || Keyboard.current.aKey.isPressed || Keyboard.current.dKey.isPressed))
            stateMachine.SwitchState(typeof(PlayerState_Idle));
       
        

        
        
    }
}
