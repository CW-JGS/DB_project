using JevonsGame.Characters;

namespace JevonsGame.States;

public class CombatState : State
{
    private Enemy enemy;
    private Jevon jevon;

    public CombatState(StateMachine stateMachine, Jevon jevon, Enemy enemy) : base(stateMachine)
    {
        this.enemy = enemy;
        this.jevon = jevon;
    }

    public override void OnEnter()
    {
        //TODO display enemy combat text and decision to coninue
    }

    public override void OnExit()
    {
        throw new NotImplementedException();
    }

    public override void GenerateDecisions()
    {
        throw new NotImplementedException();
    }
}