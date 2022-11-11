namespace JevonsGame.Characters;

public class Chelton : Enemy
{
    public Attack Attack { get; set; }
    public Chelton() : base(10, "Nig Killer Chelton", "Prepare to die my nig")
    {
        Attack = new CommandLine();
    }
}