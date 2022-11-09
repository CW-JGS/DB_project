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
        var play1Decision = new Decision()
        {
            DecisionText = "Exit",
            DecisionResponse = new Action(() => Console.WriteLine("Game Starting..."))
        };
        var play2Decision = new Decision()
        {
            DecisionText = "Jevon",
            DecisionResponse = new Action(() => Console.WriteLine("Game Starting..."))
        };
        var play3Decision = new Decision()
        {
            DecisionText = "Settings",
            DecisionResponse = new Action(() => Console.WriteLine("Game Starting..."))
        };
        decisionEngine.AddDecision(playDecision);
        decisionEngine.AddDecision(play1Decision);
        decisionEngine.AddDecision(play2Decision);
        decisionEngine.AddDecision(play3Decision);
        decisionEngine.ConcurrentText = "JEVON'S GAME\n JEVON\n JEVON\n JEVON";
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