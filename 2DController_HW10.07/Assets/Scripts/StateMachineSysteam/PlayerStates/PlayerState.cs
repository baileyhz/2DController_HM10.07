using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : ScriptableObject,IState
{
    protected float currentSpeed;

    protected Animator animator;

    protected PlayerController controller;

    protected PlayerStateMachine stateMachine ;

    public void Initialize(Animator animator , PlayerStateMachine stateMachine , PlayerController playerController)
    {
        this.animator = animator;
        this.stateMachine = stateMachine;
        this.controller = playerController;
    }

    public virtual void Enter()
    {
      
    }

    public virtual void Exit()
    {
       
    }

    public virtual void LogicUpdate()
    {
        
    }

    public virtual void PhysicUpdate()
    {
       
    }

   
}
