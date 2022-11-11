namespace JevonsGame.Characters;

public abstract class Enemy: ICharacter
{
    protected Enemy(float maxHealth, string name, string combatText)
    {
        MaxHealth = maxHealth;
        CurrentHealth = maxHealth;
        Name = name;
        CombatText = combatText;
    }

    public virtual bool Attack(float damage)
    {
        CurrentHealth = Math.Clamp(CurrentHealth - damage, 0.0f, float.MaxValue);
        if (CurrentHealth < 0.9f)
            return true;
        return false;
    }
    
    public float MaxHealth { get; set; }
    public float CurrentHealth { get; set; }
    public string Name { get; set; }
    public string CombatText { get; set; }
}