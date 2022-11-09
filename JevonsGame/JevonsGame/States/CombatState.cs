using JevonsGame.Characters;

namespace JevonsGame.States;

public class CombatState : IState
{
    private Enemy enemy;
    private Jevon jevon;

    public CombatState(ICharacter jevon, ICharacter enemy)
    {
        this.enemy = this.enemy;
        this.jevon = this.jevon;
    }

    public void OnEnter()
    {
        throw new NotImplementedException();
    }

    public void OnExit()
    {
        throw new NotImplementedException();
    }
}