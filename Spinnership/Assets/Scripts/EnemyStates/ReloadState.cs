using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadState : State
{
    public ReloadState(Enemy enemy, StateMachine stateMachine) : base(enemy, stateMachine)
    {
    }

    public override void Enter()
    {
        enemy.anim.SetTrigger("setReload");
    }

    public override void Exit()
    {
        enemy.anim.ResetTrigger("setReload");
    }

    public override void LogicUpdate()
    {}

    public override void PhysicsUpdate()
    {}

    public override void GetStopEvent(string letter)
    {
        if (letter == "r")
            stateMachine.ChangeState(enemy.chase);
    }
}
