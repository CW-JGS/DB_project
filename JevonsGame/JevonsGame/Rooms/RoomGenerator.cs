using System.Diagnostics;

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

        Room wall = new Room();
        Room tb = new Room();
        
        rooms.Add(0, wall);
        rooms.Add(1, tb);
    }
}