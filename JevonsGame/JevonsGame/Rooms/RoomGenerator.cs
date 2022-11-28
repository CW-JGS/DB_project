using System.Diagnostics;
using JevonsGame.Characters;

namespace JevonsGame.Rooms;

public class RoomGenerator
{
    public Dictionary<int, Room> rooms;

    public RoomGenerator()
    {
        Initialize();
        DebugGenerate();
    }

    public void Initialize()
    {
        rooms = new Dictionary<int, Room>();
    }

    public void DebugGenerate()
    {
        //TODO this is just for testing, get rid of it for beta generate rooms through db

        Room wall = new Room()
        {
            RoomDescription = "You have known this wall for 10 years. It is mildly annoying to you. You believe the wall is brittle enough to break",
            decisions = new List<Decision>(){new Decision()}
        };
        Room tb = new Room
        {
            enemy = new Chelton()
        };

        rooms.Add(0, wall);
        rooms.Add(1, tb);
    }
}