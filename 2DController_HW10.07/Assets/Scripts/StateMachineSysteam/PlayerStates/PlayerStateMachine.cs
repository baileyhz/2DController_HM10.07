using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{

    

    [SerializeField] PlayerState[] states;
    
    PlayerController controller;

    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();

        controller = GetComponent<PlayerController>();

        //ª¬ºAªì©l¤Æ
        stateTable = new Dictionary<System.Type, IState>(states.Length);

        foreach (PlayerState state in states)
        {
            state.Initialize(animator ,this ,controller);
            stateTable.Add(state.GetType(), state);
        }
    }

    private void Start()
    {
        SwitchOn(stateTable[typeof(PlayerState_Idle)]);
    }
}
