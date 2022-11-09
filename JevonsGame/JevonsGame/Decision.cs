namespace JevonsGame;

public class Decision
{
    public string DecisionText { get; set; }
    public Action DecisionResponse { get; set; }

    public void Select()
    {
        DecisionResponse();
    }
}