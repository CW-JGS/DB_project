using JevonsGame.Characters;

namespace JevonsGame.States;

public class CombatState : State
{
    private Enemy enemy;
    private Jevon jevon;

    public CombatState(StateMachine stateMachine, ICharacter jevon, ICharacter enemy) : base(stateMachine)
    {
        this.enemy = this.enemy;
        this.jevon = this.jevon;
    }

    public override void OnEnter()
    {
        throw new NotImplementedException();
    }

    public override void OnExit()
    {
        throw new NotImplementedException();
    }
}