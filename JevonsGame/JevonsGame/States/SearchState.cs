using JevonsGame.Rooms;

namespace JevonsGame.States;

public class SearchState : State
{

    public override void OnEnter()
    {
        Console.WriteLine("You have begun searching a room");
    }

    public override void OnExit()
    {
    }
    
    public override void GenerateDecisions()
    {
        Console.WriteLine("Decisions being generated");
    }

    public void RefreshState()
    {
        
    }
    
    public SearchState(StateMachine stateMachine) : base(stateMachine)
    {
    }
}