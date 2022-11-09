namespace JevonsGame.States;

public class StateMachine
{
    private State currentState;
    public Game game;

    public StateMachine(Game game)
    {
        this.game = game;
    }

    public void TransitionState(State state)
    {
        currentState?.OnExit();
        currentState = state;
        currentState.OnEnter();

    }
}