using System.Diagnostics;

namespace JevonsGame.States;

public class TitleState : State
{
    public override void OnEnter()
    {
        RenderTitleScreen();
        GenerateDecisions();
    }

    public void RenderTitleScreen()
    {
        Console.WriteLine("Welcome to Jevon's Game");    
    }

    public void GenerateDecisions()
    {
        var decisionEngine = stateMachine.game.decisionEngine;

        var playDecision = new Decision()
        {
            DecisionText = "Play",
            DecisionResponse = new Action(() => Console.WriteLine("Game Starting..."))
        };
        var exitDecision = new Decision()
        {
            DecisionText = "Exit",
            DecisionResponse = new Action(() => Console.WriteLine("Game Starting..."))
        };
        decisionEngine.AddDecision(playDecision);
        decisionEngine.AddDecision(exitDecision);
        decisionEngine.ConcurrentText = "JEVON'S GAME";
        decisionEngine.Start();
    }

    public override void OnExit()
    {
        Console.WriteLine("Game Started.");
    }

    public TitleState(StateMachine stateMachine) : base(stateMachine)
    {
    }
}