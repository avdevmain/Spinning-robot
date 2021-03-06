using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{

public IdleState(Enemy enemy, StateMachine stateMachine) : base(enemy, stateMachine)
{
}

Vector3 offset;

float distanceToStop = 0.5f;
float timer;
float maxTimer = 4f;



public override void Enter()
{
    enemy.anim.SetTrigger("setIdle");

    timer = Random.Range(1, maxTimer);

    offset = new Vector3(0,5,0);
}

public override void Exit()
{
    enemy.anim.ResetTrigger("setIdle");
}

public override void LogicUpdate()
{

    timer-= 1*Time.deltaTime; 
    if (timer<=0) //При истечении таймера ожидания переходит в патрулирование
        if (!enemy.tutorialMode)
            stateMachine.ChangeState(enemy.patrol);

    if (enemy.keyTarget)
    { 
        if (enemy.target != null)
            stateMachine.ChangeState(enemy.chase);
    }
}

public override void PhysicsUpdate()
{
    
}





}