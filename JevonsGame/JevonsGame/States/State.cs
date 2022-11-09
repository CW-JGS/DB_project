namespace JevonsGame.States;

public abstract class State
{
    protected StateMachine stateMachine;

    public State(StateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }
    public abstract void OnEnter();
    public abstract void OnExit();
}