using JevonsGame.States;

namespace JevonsGame;
public class Game
{
    private StateMachine stateMachine;

    public DecisionEngine decisionEngine;
    
    public Game()
    {
        decisionEngine = new DecisionEngine();
        stateMachine = new StateMachine(this);
        stateMachine.TransitionState(new TitleState(stateMachine));
    }

    public void GenerateDecisions()
    {
        
    }
    
    private static void Main(string[] args)
    {
        new Game();
    }
}