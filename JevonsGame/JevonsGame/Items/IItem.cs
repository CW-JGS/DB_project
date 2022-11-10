namespace JevonsGame.States;

public interface IItem
{
    public String Name { get; set; }
    public String Description { get; set; }
    public Action Effect { get; set; }
}