using System.Drawing;

namespace JevonsGame;

public class DecisionEngine
{
    public String ConcurrentText { get; set; }
    public List<Decision> decisions;

    public DecisionEngine()
    {
        ResetDecisions();
    }

    public void ResetDecisions()
    {
        decisions = new List<Decision>();
    }

    public void AddDecision(Decision decision)
    {
        decisions.Add(decision);
    }

    int ConCurrentTextM()
    {
        Console.SetCursorPosition(0, 0);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(ConcurrentText);
        var lines = ConcurrentText.Split('\n').Length;
        return lines;
    }
    
    public void Start()
    {
        var decision = ConsoleHelper.MultipleChoice(() => ConCurrentTextM(), false, decisions.ToArray());
        Console.Clear();
        decision.DecisionResponse();
    }
}