namespace JevonsGame.States;

public class StateMachine
{
    public State currentState;
    public Game game;

    public StateMachine(Game game)
    {
        this.game = game;
    }

    public void TransitionState(State state)
    {
        //if the state is the same, no point transitioning
        if (currentState != null && state.GetType() == currentState.GetType())
            return;
        currentState?.OnExit();
        currentState = state;
        currentState.OnEnter();

    }
}