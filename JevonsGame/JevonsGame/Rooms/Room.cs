using System.CodeDom.Compiler;
using JevonsGame.Characters;
using JevonsGame.States;

namespace JevonsGame.Rooms;

public class Room
{
    public int roomID;
    public List<Decision> decisions;
    public List<IItem> items;
    public Enemy enemy;
    public String RoomDescription { get; set; }
    public Position position { get; set; }

    public void EnterRoom(StateMachine stateMachine)
    {
        stateMachine.game.currentRoom = this;
        stateMachine.TransitionState(new SearchState(stateMachine));
        Console.WriteLine($"You have entered a room. {RoomDescription}");
        stateMachine.currentState.GenerateDecisions();
    }
    
    private bool HasEnemy() => enemy != null;

    private void GenerateDecisions()
    {
        //TODO generate the decisions when initialized
    }
    
}