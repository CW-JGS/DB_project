namespace JevonsGame;

public struct Position
{
    public Position(Room north, Room east, Room south, Room west)
    {
        North = north;
        East = east;
        South = south;
        West = west;
    }

    public Room North { get; }
    public Room East { get; }
    public Room South { get; }
    public Room West { get; }
}