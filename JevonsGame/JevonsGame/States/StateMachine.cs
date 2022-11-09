namespace JevonsGame.States;

public class StateMachine
{
    private IState currentState;

    public void TransitionState(IState state)
    {
        currentState?.OnExit();
        currentState = state;
        currentState.OnEnter();

    }
}