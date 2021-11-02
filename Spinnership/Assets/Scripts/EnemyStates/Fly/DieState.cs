using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieState : State
{
    public DieState(Enemy enemy, StateMachine stateMachine) : base(enemy, stateMachine)
    {
    }
   
   
   public override void Enter()
    {
        Debug.Log("in dieState!");
        enemy.anim.SetTrigger("setDie");
    }

    public override void Exit()
    {}

    public override void LogicUpdate()
    {
    }

    public override void PhysicsUpdate()
    {}

    public override void GetStopEvent(string letter)
    {
        if (letter == "die")
            enemy.TimeToDie();
    }

}