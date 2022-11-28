using JevonsGame.Rooms;
using JevonsGame.States;

namespace JevonsGame;
public class Game
{
    private StateMachine stateMachine;

    public DecisionEngine decisionEngine;

    public RoomGenerator roomGenerator;

    public Room currentRoom;

    
    public Game()
    {
        roomGenerator = new RoomGenerator();
        currentRoom = roomGenerator.rooms[0];
        decisionEngine = new DecisionEngine();
        stateMachine = new StateMachine(this);
        stateMachine.TransitionState(new TitleState(stateMachine));
    }

    
    private static void Main(string[] args)
    {
        new Game();
    }
}